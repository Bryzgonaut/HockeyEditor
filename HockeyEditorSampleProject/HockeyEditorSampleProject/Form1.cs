﻿using System;
using HockeyEditor;
using System.Windows.Forms;

namespace HockeyEditorSampleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MemoryEditor.Init(false);
            InitializeComponent();
            timer1.Start();
        }

        private void ResetPuck_Click(object sender, EventArgs e)
        {
            Puck.Position = new HQMVector( 15f, 0.5f, 30.5f );
        }

        private void ResetVel_Click(object sender, EventArgs e)
        {
            Puck.Velocity = new HQMVector ( 0f, 0f, 0f );
        }

        private void ResetSpin_Click(object sender, EventArgs e)
        {
            Puck.RotationalVelocity = new HQMVector ( 0f, 0f, 0f );
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PuckPos_Click(object sender, EventArgs e)
        {
            Puck.Velocity = (PlayerManager.LocalPlayer.StickPosition - Puck.Position).Normalized * 0.1f;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HQMVector puckPos = Puck.Position;
            PuckPos.Text = "Puck Pos: (" + puckPos + ")";

            HQMVector puckRot = Puck.RotationalVelocity;
            PuckSpin.Text = "Puck Spin: (" + puckRot + ")";

            HQMVector puckVel = Puck.Velocity;
            PuckVel.Text = "Puck Velocity: (" + puckVel + ")";

            HQMVector playerPos = PlayerManager.LocalPlayer.Position;
            PlayerPos.Text = "Player Pos: (" + playerPos + ")";

            HQMVector playerStickPos = PlayerManager.LocalPlayer.StickPosition;
            PlayerStick.Text = "Player Stick Pos: (" + playerStickPos + ")";
        }
    }
}
