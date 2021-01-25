﻿namespace SemiconductorMaterialsCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InterpolateButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SequanceChoiceNumber = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.LayerIThicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.LayerIIThicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.LayerIIIThicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.LayerIVThicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.LayerVThicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.xParamLay3 = new System.Windows.Forms.NumericUpDown();
            this.yParamLay3 = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.TemperatureUpDown = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.yParamLay2 = new System.Windows.Forms.NumericUpDown();
            this.xParamLay2 = new System.Windows.Forms.NumericUpDown();
            this.yParamLay1 = new System.Windows.Forms.NumericUpDown();
            this.xParamLay1 = new System.Windows.Forms.NumericUpDown();
            this.bParamNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.aParamNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EnergyChartCreationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SequanceChoiceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerIThicknessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerIIThicknessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerIIIThicknessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerIVThicknessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerVThicknessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xParamLay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yParamLay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yParamLay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xParamLay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yParamLay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xParamLay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bParamNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aParamNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(376, 473);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(172, 53);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create ax+b chart";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 478);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "parameter a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 506);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "parameter b:";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cartesianChart1.Location = new System.Drawing.Point(21, 605);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(4);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(715, 364);
            this.cartesianChart1.TabIndex = 5;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 532);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chart of function y=a*x+b for given a,b parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(832, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "x parameter(layer1):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(832, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "y parameter(layer1):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(832, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "x parameter(layer2):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(832, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "y parameter(layer2):";
            // 
            // InterpolateButton
            // 
            this.InterpolateButton.Location = new System.Drawing.Point(1232, 208);
            this.InterpolateButton.Name = "InterpolateButton";
            this.InterpolateButton.Size = new System.Drawing.Size(134, 50);
            this.InterpolateButton.TabIndex = 17;
            this.InterpolateButton.Text = "Interpolate thin layers";
            this.InterpolateButton.UseVisualStyleBackColor = true;
            this.InterpolateButton.Click += new System.EventHandler(this.InterpolateButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(34, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "I: cover layer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(34, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "II: thin layer 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(26, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "V: cover layer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(26, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "III: thin layer 2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(29, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 24);
            this.label14.TabIndex = 22;
            this.label14.Text = "IV: thin layer 3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(384, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "material";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(403, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "GaAs";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(298, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(204, 16);
            this.label17.TabIndex = 25;
            this.label17.Text = "choose layer sequance (\'1\' or \'2\')";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(259, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 16);
            this.label18.TabIndex = 26;
            this.label18.Text = "AlGaAsSb";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(403, 394);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 16);
            this.label23.TabIndex = 31;
            this.label23.Text = "GaAs";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(464, 231);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 16);
            this.label19.TabIndex = 33;
            this.label19.Text = "AlGaAsSb";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(465, 173);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 16);
            this.label20.TabIndex = 32;
            this.label20.Text = "GaInAsSb";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(259, 301);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 16);
            this.label21.TabIndex = 35;
            this.label21.Text = "AlGaAsSb";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(259, 234);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 16);
            this.label22.TabIndex = 34;
            this.label22.Text = "GaInAsSb";
            // 
            // SequanceChoiceNumber
            // 
            this.SequanceChoiceNumber.Location = new System.Drawing.Point(376, 119);
            this.SequanceChoiceNumber.Name = "SequanceChoiceNumber";
            this.SequanceChoiceNumber.Size = new System.Drawing.Size(57, 22);
            this.SequanceChoiceNumber.TabIndex = 36;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.Location = new System.Drawing.Point(631, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(110, 20);
            this.label24.TabIndex = 39;
            this.label24.Text = "thickness [nm]";
            // 
            // LayerIThicknessUpDown
            // 
            this.LayerIThicknessUpDown.Location = new System.Drawing.Point(636, 55);
            this.LayerIThicknessUpDown.Name = "LayerIThicknessUpDown";
            this.LayerIThicknessUpDown.Size = new System.Drawing.Size(120, 22);
            this.LayerIThicknessUpDown.TabIndex = 40;
            // 
            // LayerIIThicknessUpDown
            // 
            this.LayerIIThicknessUpDown.Location = new System.Drawing.Point(636, 170);
            this.LayerIIThicknessUpDown.Name = "LayerIIThicknessUpDown";
            this.LayerIIThicknessUpDown.Size = new System.Drawing.Size(120, 22);
            this.LayerIIThicknessUpDown.TabIndex = 41;
            // 
            // LayerIIIThicknessUpDown
            // 
            this.LayerIIIThicknessUpDown.Location = new System.Drawing.Point(636, 232);
            this.LayerIIIThicknessUpDown.Name = "LayerIIIThicknessUpDown";
            this.LayerIIIThicknessUpDown.Size = new System.Drawing.Size(120, 22);
            this.LayerIIIThicknessUpDown.TabIndex = 42;
            // 
            // LayerIVThicknessUpDown
            // 
            this.LayerIVThicknessUpDown.Location = new System.Drawing.Point(636, 296);
            this.LayerIVThicknessUpDown.Name = "LayerIVThicknessUpDown";
            this.LayerIVThicknessUpDown.Size = new System.Drawing.Size(120, 22);
            this.LayerIVThicknessUpDown.TabIndex = 43;
            // 
            // LayerVThicknessUpDown
            // 
            this.LayerVThicknessUpDown.Location = new System.Drawing.Point(636, 392);
            this.LayerVThicknessUpDown.Name = "LayerVThicknessUpDown";
            this.LayerVThicknessUpDown.Size = new System.Drawing.Size(120, 22);
            this.LayerVThicknessUpDown.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(832, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "y parameter(layer3):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(832, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "x parameter(layer3):";
            // 
            // xParamLay3
            // 
            this.xParamLay3.Location = new System.Drawing.Point(1074, 280);
            this.xParamLay3.Name = "xParamLay3";
            this.xParamLay3.Size = new System.Drawing.Size(120, 22);
            this.xParamLay3.TabIndex = 47;
            // 
            // yParamLay3
            // 
            this.yParamLay3.Location = new System.Drawing.Point(1074, 310);
            this.yParamLay3.Name = "yParamLay3";
            this.yParamLay3.Size = new System.Drawing.Size(120, 22);
            this.yParamLay3.TabIndex = 48;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(956, 14);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(110, 17);
            this.label25.TabIndex = 49;
            this.label25.Text = "temperature [K]:";
            // 
            // TemperatureUpDown
            // 
            this.TemperatureUpDown.Location = new System.Drawing.Point(973, 37);
            this.TemperatureUpDown.Name = "TemperatureUpDown";
            this.TemperatureUpDown.Size = new System.Drawing.Size(120, 22);
            this.TemperatureUpDown.TabIndex = 50;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(465, 301);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 16);
            this.label26.TabIndex = 51;
            this.label26.Text = "GaInAsSb";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(249, 144);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 16);
            this.label27.TabIndex = 52;
            this.label27.Text = "sequance 1";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(465, 144);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 16);
            this.label28.TabIndex = 53;
            this.label28.Text = "sequance 2";
            // 
            // yParamLay2
            // 
            this.yParamLay2.Location = new System.Drawing.Point(1074, 245);
            this.yParamLay2.Name = "yParamLay2";
            this.yParamLay2.Size = new System.Drawing.Size(120, 22);
            this.yParamLay2.TabIndex = 54;
            // 
            // xParamLay2
            // 
            this.xParamLay2.Location = new System.Drawing.Point(1074, 217);
            this.xParamLay2.Name = "xParamLay2";
            this.xParamLay2.Size = new System.Drawing.Size(120, 22);
            this.xParamLay2.TabIndex = 55;
            // 
            // yParamLay1
            // 
            this.yParamLay1.Location = new System.Drawing.Point(1074, 184);
            this.yParamLay1.Name = "yParamLay1";
            this.yParamLay1.Size = new System.Drawing.Size(120, 22);
            this.yParamLay1.TabIndex = 56;
            // 
            // xParamLay1
            // 
            this.xParamLay1.Location = new System.Drawing.Point(1074, 156);
            this.xParamLay1.Name = "xParamLay1";
            this.xParamLay1.Size = new System.Drawing.Size(120, 22);
            this.xParamLay1.TabIndex = 57;
            // 
            // bParamNumericUpDown
            // 
            this.bParamNumericUpDown.Location = new System.Drawing.Point(227, 503);
            this.bParamNumericUpDown.Name = "bParamNumericUpDown";
            this.bParamNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.bParamNumericUpDown.TabIndex = 59;
            // 
            // aParamNumericUpDown
            // 
            this.aParamNumericUpDown.Location = new System.Drawing.Point(227, 473);
            this.aParamNumericUpDown.Name = "aParamNumericUpDown";
            this.aParamNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.aParamNumericUpDown.TabIndex = 58;
            // 
            // EnergyChartCreationButton
            // 
            this.EnergyChartCreationButton.Location = new System.Drawing.Point(595, 474);
            this.EnergyChartCreationButton.Name = "EnergyChartCreationButton";
            this.EnergyChartCreationButton.Size = new System.Drawing.Size(145, 58);
            this.EnergyChartCreationButton.TabIndex = 60;
            this.EnergyChartCreationButton.Text = "Create energy chart";
            this.EnergyChartCreationButton.UseVisualStyleBackColor = true;
            this.EnergyChartCreationButton.Click += new System.EventHandler(this.EnergyChartCreationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 989);
            this.Controls.Add(this.EnergyChartCreationButton);
            this.Controls.Add(this.bParamNumericUpDown);
            this.Controls.Add(this.aParamNumericUpDown);
            this.Controls.Add(this.xParamLay1);
            this.Controls.Add(this.yParamLay1);
            this.Controls.Add(this.xParamLay2);
            this.Controls.Add(this.yParamLay2);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.TemperatureUpDown);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.yParamLay3);
            this.Controls.Add(this.xParamLay3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LayerVThicknessUpDown);
            this.Controls.Add(this.LayerIVThicknessUpDown);
            this.Controls.Add(this.LayerIIIThicknessUpDown);
            this.Controls.Add(this.LayerIIThicknessUpDown);
            this.Controls.Add(this.LayerIThicknessUpDown);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.SequanceChoiceNumber);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.InterpolateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(10000, 7000);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Form1";
            this.Text = "SMC - Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.SequanceChoiceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerIThicknessUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerIIThicknessUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerIIIThicknessUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerIVThicknessUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerVThicknessUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xParamLay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yParamLay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yParamLay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xParamLay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yParamLay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xParamLay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bParamNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aParamNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button InterpolateButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown SequanceChoiceNumber;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown LayerIThicknessUpDown;
        private System.Windows.Forms.NumericUpDown LayerIIThicknessUpDown;
        private System.Windows.Forms.NumericUpDown LayerIIIThicknessUpDown;
        private System.Windows.Forms.NumericUpDown LayerIVThicknessUpDown;
        private System.Windows.Forms.NumericUpDown LayerVThicknessUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown xParamLay3;
        private System.Windows.Forms.NumericUpDown yParamLay3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown TemperatureUpDown;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown yParamLay2;
        private System.Windows.Forms.NumericUpDown xParamLay2;
        private System.Windows.Forms.NumericUpDown yParamLay1;
        private System.Windows.Forms.NumericUpDown xParamLay1;
        private System.Windows.Forms.NumericUpDown bParamNumericUpDown;
        private System.Windows.Forms.NumericUpDown aParamNumericUpDown;
        private System.Windows.Forms.Button EnergyChartCreationButton;
    }
}

