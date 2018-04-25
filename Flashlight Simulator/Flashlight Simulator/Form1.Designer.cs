namespace Flashlight_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBatteryIn = new System.Windows.Forms.Button();
            this.btnBatteryOut = new System.Windows.Forms.Button();
            this.btnFlashlightOn = new System.Windows.Forms.Button();
            this.btnFlashlightOff = new System.Windows.Forms.Button();
            this.btnBulbIn = new System.Windows.Forms.Button();
            this.btnBulbChange = new System.Windows.Forms.Button();
            this.tbFlashlightState = new System.Windows.Forms.TextBox();
            this.tbBulbStrength = new System.Windows.Forms.TextBox();
            this.tbBattery1State = new System.Windows.Forms.TextBox();
            this.tbBattery2State = new System.Windows.Forms.TextBox();
            this.tbBattery3State = new System.Windows.Forms.TextBox();
            this.tbBattery4State = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prgBattery1 = new System.Windows.Forms.ProgressBar();
            this.prgBattery2 = new System.Windows.Forms.ProgressBar();
            this.prgBattery3 = new System.Windows.Forms.ProgressBar();
            this.prgBattery4 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnBatteryIn
            // 
            this.btnBatteryIn.Location = new System.Drawing.Point(12, 94);
            this.btnBatteryIn.Name = "btnBatteryIn";
            this.btnBatteryIn.Size = new System.Drawing.Size(96, 23);
            this.btnBatteryIn.TabIndex = 0;
            this.btnBatteryIn.Text = "Włóż baterie";
            this.btnBatteryIn.UseVisualStyleBackColor = true;
            this.btnBatteryIn.Click += new System.EventHandler(this.btnBatteryIn_Click);
            // 
            // btnBatteryOut
            // 
            this.btnBatteryOut.Location = new System.Drawing.Point(12, 123);
            this.btnBatteryOut.Name = "btnBatteryOut";
            this.btnBatteryOut.Size = new System.Drawing.Size(96, 23);
            this.btnBatteryOut.TabIndex = 1;
            this.btnBatteryOut.Text = "Wyjmij baterię";
            this.btnBatteryOut.UseVisualStyleBackColor = true;
            this.btnBatteryOut.Click += new System.EventHandler(this.btnBatteryOut_Click);
            // 
            // btnFlashlightOn
            // 
            this.btnFlashlightOn.Location = new System.Drawing.Point(12, 12);
            this.btnFlashlightOn.Name = "btnFlashlightOn";
            this.btnFlashlightOn.Size = new System.Drawing.Size(96, 23);
            this.btnFlashlightOn.TabIndex = 2;
            this.btnFlashlightOn.Text = "Włącz latarkę";
            this.btnFlashlightOn.UseVisualStyleBackColor = true;
            this.btnFlashlightOn.Click += new System.EventHandler(this.btnFlashlightOn_Click);
            // 
            // btnFlashlightOff
            // 
            this.btnFlashlightOff.Location = new System.Drawing.Point(12, 41);
            this.btnFlashlightOff.Name = "btnFlashlightOff";
            this.btnFlashlightOff.Size = new System.Drawing.Size(96, 23);
            this.btnFlashlightOff.TabIndex = 3;
            this.btnFlashlightOff.Text = "Wyłącz latarkę";
            this.btnFlashlightOff.UseVisualStyleBackColor = true;
            this.btnFlashlightOff.Click += new System.EventHandler(this.btnFlashlightOff_Click);
            // 
            // btnBulbIn
            // 
            this.btnBulbIn.Location = new System.Drawing.Point(12, 176);
            this.btnBulbIn.Name = "btnBulbIn";
            this.btnBulbIn.Size = new System.Drawing.Size(96, 23);
            this.btnBulbIn.TabIndex = 4;
            this.btnBulbIn.Text = "Włóż żarówkę";
            this.btnBulbIn.UseVisualStyleBackColor = true;
            this.btnBulbIn.Click += new System.EventHandler(this.btnBulbIn_Click);
            // 
            // btnBulbChange
            // 
            this.btnBulbChange.Location = new System.Drawing.Point(12, 205);
            this.btnBulbChange.Name = "btnBulbChange";
            this.btnBulbChange.Size = new System.Drawing.Size(96, 23);
            this.btnBulbChange.TabIndex = 5;
            this.btnBulbChange.Text = "Wymień żarówkę";
            this.btnBulbChange.UseVisualStyleBackColor = true;
            this.btnBulbChange.Click += new System.EventHandler(this.btnBulbChange_Click);
            // 
            // tbFlashlightState
            // 
            this.tbFlashlightState.BackColor = System.Drawing.Color.Red;
            this.tbFlashlightState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFlashlightState.Location = new System.Drawing.Point(251, 29);
            this.tbFlashlightState.Name = "tbFlashlightState";
            this.tbFlashlightState.ReadOnly = true;
            this.tbFlashlightState.Size = new System.Drawing.Size(100, 20);
            this.tbFlashlightState.TabIndex = 6;
            this.tbFlashlightState.Text = "WYŁĄCZONA";
            this.tbFlashlightState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBulbStrength
            // 
            this.tbBulbStrength.BackColor = System.Drawing.Color.White;
            this.tbBulbStrength.Location = new System.Drawing.Point(251, 55);
            this.tbBulbStrength.Name = "tbBulbStrength";
            this.tbBulbStrength.ReadOnly = true;
            this.tbBulbStrength.Size = new System.Drawing.Size(100, 20);
            this.tbBulbStrength.TabIndex = 7;
            this.tbBulbStrength.Text = "brak żarówki";
            this.tbBulbStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBulbStrength.TextChanged += new System.EventHandler(this.tbBulbStrength_TextChanged);
            // 
            // tbBattery1State
            // 
            this.tbBattery1State.Location = new System.Drawing.Point(221, 94);
            this.tbBattery1State.Name = "tbBattery1State";
            this.tbBattery1State.ReadOnly = true;
            this.tbBattery1State.Size = new System.Drawing.Size(24, 20);
            this.tbBattery1State.TabIndex = 8;
            // 
            // tbBattery2State
            // 
            this.tbBattery2State.Location = new System.Drawing.Point(221, 123);
            this.tbBattery2State.Name = "tbBattery2State";
            this.tbBattery2State.ReadOnly = true;
            this.tbBattery2State.Size = new System.Drawing.Size(24, 20);
            this.tbBattery2State.TabIndex = 9;
            // 
            // tbBattery3State
            // 
            this.tbBattery3State.Location = new System.Drawing.Point(221, 152);
            this.tbBattery3State.Name = "tbBattery3State";
            this.tbBattery3State.ReadOnly = true;
            this.tbBattery3State.Size = new System.Drawing.Size(24, 20);
            this.tbBattery3State.TabIndex = 10;
            // 
            // tbBattery4State
            // 
            this.tbBattery4State.Location = new System.Drawing.Point(221, 181);
            this.tbBattery4State.Name = "tbBattery4State";
            this.tbBattery4State.ReadOnly = true;
            this.tbBattery4State.Size = new System.Drawing.Size(24, 20);
            this.tbBattery4State.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Stan latarki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Moc żarówki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bateria 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bateria 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bateria 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 184);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Bateria 4";
            // 
            // prgBattery1
            // 
            this.prgBattery1.Location = new System.Drawing.Point(251, 94);
            this.prgBattery1.Name = "prgBattery1";
            this.prgBattery1.Size = new System.Drawing.Size(100, 23);
            this.prgBattery1.TabIndex = 19;
            // 
            // prgBattery2
            // 
            this.prgBattery2.Location = new System.Drawing.Point(251, 123);
            this.prgBattery2.Name = "prgBattery2";
            this.prgBattery2.Size = new System.Drawing.Size(100, 23);
            this.prgBattery2.TabIndex = 20;
            // 
            // prgBattery3
            // 
            this.prgBattery3.Location = new System.Drawing.Point(251, 152);
            this.prgBattery3.Name = "prgBattery3";
            this.prgBattery3.Size = new System.Drawing.Size(100, 23);
            this.prgBattery3.TabIndex = 21;
            // 
            // prgBattery4
            // 
            this.prgBattery4.Location = new System.Drawing.Point(251, 181);
            this.prgBattery4.Name = "prgBattery4";
            this.prgBattery4.Size = new System.Drawing.Size(100, 23);
            this.prgBattery4.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 241);
            this.Controls.Add(this.prgBattery4);
            this.Controls.Add(this.prgBattery3);
            this.Controls.Add(this.prgBattery2);
            this.Controls.Add(this.prgBattery1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBattery4State);
            this.Controls.Add(this.tbBattery3State);
            this.Controls.Add(this.tbBattery2State);
            this.Controls.Add(this.tbBattery1State);
            this.Controls.Add(this.tbBulbStrength);
            this.Controls.Add(this.tbFlashlightState);
            this.Controls.Add(this.btnBulbChange);
            this.Controls.Add(this.btnBulbIn);
            this.Controls.Add(this.btnFlashlightOff);
            this.Controls.Add(this.btnFlashlightOn);
            this.Controls.Add(this.btnBatteryOut);
            this.Controls.Add(this.btnBatteryIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flashlight Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBatteryIn;
        private System.Windows.Forms.Button btnBatteryOut;
        private System.Windows.Forms.Button btnFlashlightOn;
        private System.Windows.Forms.Button btnFlashlightOff;
        private System.Windows.Forms.Button btnBulbIn;
        private System.Windows.Forms.Button btnBulbChange;
        private System.Windows.Forms.TextBox tbFlashlightState;
        private System.Windows.Forms.TextBox tbBulbStrength;
        private System.Windows.Forms.TextBox tbBattery1State;
        private System.Windows.Forms.TextBox tbBattery2State;
        private System.Windows.Forms.TextBox tbBattery3State;
        private System.Windows.Forms.TextBox tbBattery4State;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar prgBattery1;
        private System.Windows.Forms.ProgressBar prgBattery2;
        private System.Windows.Forms.ProgressBar prgBattery3;
        private System.Windows.Forms.ProgressBar prgBattery4;
    }
}

