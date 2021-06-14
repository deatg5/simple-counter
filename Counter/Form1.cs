using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Counter
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        List<Count> counters = new List<Count>();
        int SelectedIndexOfListbox;
        List<int> selection = new List<int>();

        bool canChangeUpKey = false;
        bool canChangeDownKey = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            lstCounters.SelectionMode = SelectionMode.MultiExtended;

            //load
            using (StreamReader tw = new StreamReader("counters.txt"))
            {
                string line;
                while ((line = tw.ReadLine()) != null)
                {
                    counters.Add(new Count() { CounterName = line.ToString().Split(": ")[0], CounterValue = Convert.ToInt32(line.ToString().Split(": ")[1])
                });
                }
                tw.Close();
            }

            try
            {
                //load hotkeys
                using (StreamReader tw = new StreamReader("increasehotkey.txt"))
                {
                    string line;
                    while ((line = tw.ReadLine()) != null)
                    {
                        if (line != "none")
                        {
                            RegisterHotKey(
                                this.Handle, 1, 0x0000, Convert.ToInt32(line.ToString().Split(",")[0])
                            );
                            lblIncreaseKey.Text = "Increase count hotkey set to " + line.ToString().Split(",")[1];
                        }
                        else
                        {
                            lblIncreaseKey.Text = "Increase count hotkey set to: none";
                        }
                        
                    }
                    tw.Close();
                    
                }

                using (StreamReader tw = new StreamReader("decreasehotkey.txt"))
                {
                    string line;
                    while ((line = tw.ReadLine()) != null)
                    {
                        if (line != "none")
                        {
                            RegisterHotKey(
                                this.Handle, 2, 0x0000, Convert.ToInt32(line.ToString().Split(",")[0])
                            );
                            lblDecreaseKey.Text = "Decrease count hotkey set to " + line.ToString().Split(",")[1];
                        } 
                        else
                        {
                            lblDecreaseKey.Text = "Decrease count hotkey set to none";
                        }
                        
                    }
                    tw.Close();
                    
                }
            }
            catch
            {

            }
            

            RefreshForm();




        }

        protected override void WndProc(ref Message m)
        {
            // 5. Catch when a HotKey is pressed !
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                // MessageBox.Show(string.Format("Hotkey #{0} pressed", id));

                if (id == 1)
                {
                    IncreaseCount();
                }

                if (id == 2)
                {
                    DecreaseCount();
                }
            }

            base.WndProc(ref m);
        }

        bool IsInList(string name)
        {
            foreach (Count count in counters)
            {
                if (name == count.CounterName)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null && !IsInList(txtName.Text))
            {
                counters.Add(new Count() { CounterName = txtName.Text, CounterValue = 0 });
            } else
            {
                MessageBox.Show("That counter already exists.");
            }
            RefreshForm();
        }

        void RefreshForm()
        {
            if (lstCounters.SelectedIndex != -1)
                lblCount.Text = lstCounters.SelectedItem.ToString().Split(": ")[1];

            lstCounters.Items.Clear();
            foreach (Count count in counters)
            {
                lstCounters.Items.Add(count.CounterName + ": " + count.CounterValue);
            }
            try
            {
                foreach (int i in selection)
                {
                    lstCounters.SetSelected(selection[i], true);
                }
            } catch
            {
                lstCounters.SelectedIndex = -1;
            }
            


            //saving
            using (StreamWriter tw = new StreamWriter("counters.txt"))
            {

                foreach (Count count in counters)
                {
                    tw.WriteLine(count.CounterName + ": " + count.CounterValue.ToString());
                }
                tw.Close();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCounters.SelectedIndex != -1)
            {
                string message = "Delet this?";
                string title = "Delete counter";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    foreach (Count count in counters.ToList())
                    {

                        if (count.CounterName == lstCounters.SelectedItem.ToString().Split(":")[0])
                        {
                            counters.Remove(count);
                        }
                    }
                    RefreshForm();
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Select a counter to delete");
            }
            
            
        }

        private void btnStonks_Click(object sender, EventArgs e)
        {
            IncreaseCount();
        }

        private void btnNotStonks_Click(object sender, EventArgs e)
        {
            DecreaseCount();
        }

        private void lstCounters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCounters.SelectedIndex != -1)
                lblCount.Text = lstCounters.SelectedItem.ToString().Split(": ")[1];
        }

        void DecreaseCount()
        {
            selection.Clear();
            foreach (int i in lstCounters.SelectedIndices)
            {
                selection.Add(i);
                foreach (Count count in counters.ToList())
                {
                    if (count.CounterName == lstCounters.Items[i].ToString().Split(":")[0])
                    {
                        count.CounterValue -= (int)numIncAmount.Value;
                    }

                }
            }

            RefreshForm();
            foreach (int i in selection)
            {
                lstCounters.SetSelected(i, true);
            }
        }

        void IncreaseCount()
        {
            selection.Clear();
            foreach (int i in lstCounters.SelectedIndices)
            {
                selection.Add(i);
                foreach (Count count in counters.ToList())
                {
                    if (count.CounterName == lstCounters.Items[i].ToString().Split(":")[0])
                    {
                        count.CounterValue += (int)numIncAmount.Value;
                    }
                    
                }
            }


            RefreshForm();
            foreach (int i in selection)
            {
                lstCounters.SetSelected(i, true);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (canChangeUpKey == true)
            {
                UnregisterHotKey(
                    this.Handle, 1
                );
                canChangeUpKey = false;
                lblIncreaseKey.Text = "Increase count hotkey set to " + e.KeyCode.ToString();
                RegisterHotKey(
                    this.Handle, 1, 0x0000, (int)e.KeyCode
                );

                using (StreamWriter tw = new StreamWriter("increasehotkey.txt"))
                {
                    tw.WriteLine((int)e.KeyCode + "," + e.KeyCode.ToString());
                    tw.Close();
                }


            }

            if (canChangeDownKey)
            {
                UnregisterHotKey(
                    this.Handle, 2
                );
                canChangeDownKey = false;
                lblDecreaseKey.Text = "Decrease count hotkey set to " + e.KeyCode.ToString();
                RegisterHotKey(
                    this.Handle, 2, 0x0000, (int)e.KeyCode
                );

                using (StreamWriter tw = new StreamWriter("decreasehotkey.txt"))
                {
                    tw.WriteLine((int)e.KeyCode + "," + e.KeyCode.ToString());
                    tw.Close();
                }
            }
        }

        private void btnIncreaseChange_Click(object sender, EventArgs e)
        {
            canChangeUpKey = true;
            lblIncreaseKey.Text = "Press a key now to set as hotkey";
        }

        private void btnDecreaseChange_Click(object sender, EventArgs e)
        {
            canChangeDownKey = true;
            lblDecreaseKey.Text = "Press a key now to set as hotkey";
        }

        private void btnClearIncreaseHotkey_Click(object sender, EventArgs e)
        {
            UnregisterHotKey(
                    this.Handle, 1
                );
            lblIncreaseKey.Text = "Increase hotkey set to: none";
            using (StreamWriter tw = new StreamWriter("increasehotkey.txt"))
            {
                tw.WriteLine("none,none");
                tw.Close();
            }
        }

        private void btnClearDecreaseHotkey_Click(object sender, EventArgs e)
        {
            UnregisterHotKey(
                   this.Handle, 2
               );
            lblDecreaseKey.Text = "Decrease hotkey set to: none";
            using (StreamWriter tw = new StreamWriter("decreasehotkey.txt"))
            {
                tw.WriteLine("none,none");
                tw.Close();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lstCounters.SelectedIndex != -1 && !IsInList(txtNewName.Text))
            {
                foreach (Count count in counters.ToList())
                {

                    if (count.CounterName == lstCounters.SelectedItem.ToString().Split(":")[0])
                    {
                        count.CounterName = txtNewName.Text;
                    }
                }
                RefreshForm();
                
            }
            else
            {
                MessageBox.Show("Select a counter to change, or make sure that same doesn't exist already");
            }
        }

    }
}
