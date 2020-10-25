using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astromech
{
    public partial class Keybinds : Form
    {

        public Keyboard.DirectXKeyStrokes enginePowerKey;
        public Keyboard.DirectXKeyStrokes weaponPowerKey;
        public Keyboard.DirectXKeyStrokes shieldPowerKey;
        public Keyboard.DirectXKeyStrokes balancePowerKey;
        public Keyboard.DirectXKeyStrokes counterKey;
        public Keyboard.DirectXKeyStrokes forwardShieldKey;
        public Keyboard.DirectXKeyStrokes rearShieldKey;
        public Keyboard.DirectXKeyStrokes balanceShieldKey;
        public Keyboard.DirectXKeyStrokes cycleTargetsKey;
        public Keyboard.DirectXKeyStrokes targetAttackerKey;
        public Keyboard.DirectXKeyStrokes targetFriendlyKey;
        public Keyboard.DirectXKeyStrokes targetHostileKey;
        public Keyboard.DirectXKeyStrokes targetSystemsKey;
        public Keyboard.DirectXKeyStrokes targetAIKey;
        public Keyboard.DirectXKeyStrokes targetsFollowerKey;
        public Keyboard.DirectXKeyStrokes targetMissilesKey;
        public Keyboard.DirectXKeyStrokes pingKey;
        public Keyboard.DirectXKeyStrokes acknowledgeKey;
        public Keyboard.DirectXKeyStrokes modKey;

        public Keybinds()
        {
            InitializeComponent();
        }

        private void Keybinds_Load(object sender, EventArgs e)
        {
            enginePowerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            enginePowerKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_1;

            weaponPowerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            weaponPowerKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_2;

            shieldPowerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            shieldPowerKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_3;

            balancePowerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            balancePowerKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_4;

            countermeasureKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            countermeasureKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_R;

            forwardShieldKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            forwardShieldKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_9;

            rearShieldKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            rearShieldKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_0;

            balanceShieldKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            balanceShieldKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_MINUS;

            cycleKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            cycleKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_F;

            targetAttackerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetAttackerKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_G;

            targetAlliesKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetAlliesKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_F6;

            targetHostilesKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetHostilesKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_F10;

            targetSystemsKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetSystemsKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_F12;

            targetAIKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetAIKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_F11;

            targetsFollowerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetsFollowerKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_F7;

            targetMissilesKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetMissilesKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_F3;

            pingKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            pingKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_H;

            acknowledgeKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            acknowledgeKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_B;

            modKeyKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            modKeyKeybind.SelectedItem = Keyboard.DirectXKeyStrokes.DIK_LCONTROL;


        }

        private void enginePowerKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            enginePowerKey = (Keyboard.DirectXKeyStrokes)enginePowerKeybind.SelectedItem;
        }

        private void weaponPowerKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            weaponPowerKey = (Keyboard.DirectXKeyStrokes)weaponPowerKeybind.SelectedItem;
        }

        private void shieldPowerKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            shieldPowerKey = (Keyboard.DirectXKeyStrokes)shieldPowerKeybind.SelectedItem;
        }

        private void balancePowerKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            balancePowerKey = (Keyboard.DirectXKeyStrokes)balancePowerKeybind.SelectedItem;
        }

        private void countermeasureKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            counterKey = (Keyboard.DirectXKeyStrokes)countermeasureKeybind.SelectedItem;
        }

        private void forwardShieldKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            forwardShieldKey = (Keyboard.DirectXKeyStrokes)forwardShieldKeybind.SelectedItem;
        }

        private void rearShieldKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            rearShieldKey = (Keyboard.DirectXKeyStrokes)rearShieldKeybind.SelectedItem;
        }

        private void balanceShieldKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            balancePowerKey = (Keyboard.DirectXKeyStrokes)balanceShieldKeybind.SelectedItem;
        }

        private void cycleKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            cycleTargetsKey = (Keyboard.DirectXKeyStrokes)cycleKeybind.SelectedItem;
        }

        private void targetAttackerKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetAttackerKey = (Keyboard.DirectXKeyStrokes)targetAttackerKeybind.SelectedItem;
        }

        private void targetAlliesKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetFriendlyKey = (Keyboard.DirectXKeyStrokes)targetAlliesKeybind.SelectedItem;
        }

        private void targetHostilesKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetHostileKey = (Keyboard.DirectXKeyStrokes)targetHostilesKeybind.SelectedItem;
        }

        private void targetSystemsKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetSystemsKey = (Keyboard.DirectXKeyStrokes)targetSystemsKeybind.SelectedItem;
        }

        private void targetAIKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetAIKey = (Keyboard.DirectXKeyStrokes)targetAIKeybind.SelectedItem;
        }

        private void targetsFollowerKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetsFollowerKey = (Keyboard.DirectXKeyStrokes)targetsFollowerKeybind.SelectedItem;
        }

        private void targetMissilesKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetMissilesKey = (Keyboard.DirectXKeyStrokes)targetMissilesKeybind.SelectedItem;
        }

        private void pingKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            pingKey = (Keyboard.DirectXKeyStrokes)pingKeybind.SelectedItem;
        }

        private void acknowledgeKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            acknowledgeKey = (Keyboard.DirectXKeyStrokes)acknowledgeKeybind.SelectedItem;
        }

        private void modKeyKeybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            modKey = (Keyboard.DirectXKeyStrokes)modKeyKeybind.SelectedItem;
        }

    }
}
