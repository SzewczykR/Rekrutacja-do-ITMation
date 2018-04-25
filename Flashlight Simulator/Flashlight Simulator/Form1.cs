using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Flashlight_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBatteryIn_Click(object sender, EventArgs e)
        {
            if (Flashlight.GetBatteriesInCount() < 4)
            {
                Flashlight.PlugInBattery();
                switch (Flashlight.GetBatteriesInCount())
                {
                    case 1:
                        tbBattery1State.Text = Flashlight.GetPowerFromBatteriesIn(0).ToString();
                        prgBattery1.Value = Flashlight.GetPowerFromBatteriesIn(0);
                        break;
                    case 2:
                        tbBattery2State.Text = Flashlight.GetPowerFromBatteriesIn(1).ToString();
                        prgBattery2.Value = Flashlight.GetPowerFromBatteriesIn(1);
                        break;
                    case 3:
                        tbBattery3State.Text = Flashlight.GetPowerFromBatteriesIn(2).ToString();
                        prgBattery3.Value = Flashlight.GetPowerFromBatteriesIn(2);
                        break;
                    case 4:
                        tbBattery4State.Text = Flashlight.GetPowerFromBatteriesIn(3).ToString();
                        prgBattery4.Value = Flashlight.GetPowerFromBatteriesIn(3);
                        break;
                }
            }
            else
                MessageBox.Show("Nie ma miejsca na kolejne baterie!", "Błąd!");
        }

        private void btnFlashlightOn_Click(object sender, EventArgs e)
        {
            if (!Flashlight.GetIsOn() && Flashlight.GetBulbState() && Flashlight.GetBatteriesInCount() >= 2 && Flashlight.IsEnoughPower())
            {
                for(int i=0; i < Flashlight.GetBatteriesInCount(); i++)
                {

                    Flashlight.ConsumePowerFromBatteriesIn(i);
                        switch (i + 1)
                        {
                            case 1:
                                tbBattery1State.Text = Flashlight.GetPowerFromBatteriesIn(i).ToString();
                                prgBattery1.Value = Flashlight.GetPowerFromBatteriesIn(i);
                                break;
                            case 2:
                                tbBattery2State.Text = Flashlight.GetPowerFromBatteriesIn(i).ToString();
                                prgBattery2.Value = Flashlight.GetPowerFromBatteriesIn(i);
                                break;
                            case 3:
                                tbBattery3State.Text = Flashlight.GetPowerFromBatteriesIn(i).ToString();
                                prgBattery3.Value = Flashlight.GetPowerFromBatteriesIn(i);
                                break;
                            case 4:
                                tbBattery4State.Text = Flashlight.GetPowerFromBatteriesIn(i).ToString();
                                prgBattery4.Value = Flashlight.GetPowerFromBatteriesIn(i);
                                break;
                    }
                }
                tbFlashlightState.Text = "WŁĄCZONA";
                tbFlashlightState.BackColor = Color.Green;
                Flashlight.Turn(true);
            }
            else
            {
                if (Flashlight.GetIsOn())
                    MessageBox.Show("Latarka jest już włączona!", "Błąd!");
                else if (!Flashlight.GetBulbState() && Flashlight.GetBatteriesInCount() < 2)
                    MessageBox.Show("W latarce nie ma żarówki ani dostatecznej ilości baterii.", "Błąd!");
                else if (!Flashlight.GetBulbState() && !Flashlight.IsEnoughPower())
                    MessageBox.Show("W latarce nie ma żarówki ani dostatecznej ilości mocy w bateriach.", "Błąd!");
                else if (!Flashlight.GetBulbState())
                    MessageBox.Show("W latarce nie ma żarówki!", "Błąd!");
                else if (Flashlight.GetBatteriesInCount() < 2)
                    MessageBox.Show("W latarce nie ma dostatecznej ilości baterii.", "Błąd!");
                else
                    MessageBox.Show("W latarce nie ma dostatecznej ilości mocy.", "Błąd!");
            }
        }

        private void btnFlashlightOff_Click(object sender, EventArgs e)
        {
            Flashlight.Turn(false);
            tbFlashlightState.Text = "WYŁĄCZONA";
            tbFlashlightState.BackColor = Color.Red;
        }

        private void btnBulbIn_Click(object sender, EventArgs e)
        {
            Flashlight.PlugInBulb();
            tbBulbStrength.Text = Bulb.GetStrength().ToString();
            tbBulbStrength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
        }

        private void btnBulbChange_Click(object sender, EventArgs e)
        {
            if (Flashlight.GetBulbState())
            {
                string inputbox = Interaction.InputBox("Podaj moc nowej żaróweczki [1-10]", "Wymieniamy żaróweczkę", Bulb.GetStrength().ToString(), -1, -1);
                int output;
                bool isInt = Int32.TryParse(inputbox, out output);
                if (isInt && output >= 1 && output <= 10)
                {
                    Bulb.SetStrength(output);
                    tbBulbStrength.Text = output.ToString();
                    tbBulbStrength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255-output*25)))));
                }
                else
                    MessageBox.Show("Zła wartość!", "Błąd!");
            }
            else MessageBox.Show("Najpierw wsadź żarówkę!", "Błąd!");
        }

        private void btnBatteryOut_Click(object sender, EventArgs e)
        {
            if (Flashlight.GetBatteriesInCount() > 0)
            {
                Flashlight.RemoveBattery();
                switch (Flashlight.GetBatteriesInCount()+1)
                {
                    case 1:
                        tbBattery1State.Text = null;
                        prgBattery1.Value = 0;
                        break;
                    case 2:
                        tbBattery2State.Text = null;
                        prgBattery2.Value = 0;
                        break;
                    case 3:
                        tbBattery3State.Text = null;
                        prgBattery3.Value = 0;
                        break;
                    case 4:
                        tbBattery4State.Text = null;
                        prgBattery4.Value = 0;
                        break;
                }
            }
            else
                MessageBox.Show("Brak baterii w latarce!", "Błąd!");
        }

        static class Flashlight
        {
            private static List<Battery> BatteriesIn = new List<Battery>();
            private static List<Battery> BatteriesOut = new List<Battery>();
            private static bool isOn;
            private static bool isBulbIn;
            static Flashlight()
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    Battery battery = new Battery(rnd.Next(90,100));
                    BatteriesOut.Add(battery);
                }
                isOn = false;
                isBulbIn = false;
            }
            public static void Turn(bool iss)
            {
                isOn = iss;
            }
            public static bool GetIsOn()
            {
                return isOn;
            }
            public static void PlugInBulb()
            {
                isBulbIn = true;
            }
            public static void SwitchBulb(int strength)
            {
                Bulb.SetStrength(strength);
            }
            public static void RemoveBattery()
            {
                BatteriesOut.Add(BatteriesIn.ElementAt(BatteriesIn.Count-1));
                BatteriesIn.RemoveAt(BatteriesIn.Count - 1);
            }
            public static void PlugInBattery()
            {
                BatteriesIn.Add(BatteriesOut.ElementAt(0));
                BatteriesOut.RemoveAt(0);
            }
            public static int GetBatteriesInCount()
            {
                return BatteriesIn.Count;
            }
            public static bool GetBulbState()
            {
                return isBulbIn;
            }
            public static bool IsEnoughPower()
            {
                int i = 0;
                foreach (Battery battery in BatteriesIn)
                {
                    if (battery.GetPower() >= 15)
                        i++;
                }
                if (i >= 2)
                    return true;
                else
                    return false;
            }
            public static int GetPowerFromBatteriesIn(int index)
            {
                return BatteriesIn.ElementAt(index).GetPower();
            }
            public static void ConsumePowerFromBatteriesIn(int index)
            {
                BatteriesIn.ElementAt(index).ConsumePower(Bulb.GetStrength());
                if (BatteriesIn.ElementAt(index).GetPower() < 0)
                   BatteriesIn.ElementAt(index).SetPower(0);
            }
        }

        static class Bulb
        {
            private static int strength;
            static Bulb()
            {
                strength = 1;
            }
            public static void SetStrength(int sstrength)
            {
                strength = sstrength;
            }
            public static int GetStrength()
            {
                return strength;
            }
        }

        class Battery
        {
            private int power;
            public Battery(int power)
            {
                this.power = power;
            }
            public void ConsumePower(int strength)
            {
                this.power -= strength;
            }
            public int GetPower()
            {
                return power;
            }
            public void SetPower(int ppower)
            {
                power = ppower;
            }
        }

        private void tbBulbStrength_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
