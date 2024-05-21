namespace RingRacerDemo
{
    partial class RingRacerDemoLoader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RingRacerDemoLoader));
            DragDropPanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            version2_0_exe = new TextBox();
            version2_1_exe = new TextBox();
            version2_2_exe = new TextBox();
            version2_3_exe = new TextBox();
            imageList1 = new ImageList(components);
            label6 = new Label();
            additionalArgs = new TextBox();
            DragDropPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DragDropPanel
            // 
            DragDropPanel.AllowDrop = true;
            DragDropPanel.BackColor = Color.Transparent;
            DragDropPanel.BorderStyle = BorderStyle.FixedSingle;
            DragDropPanel.Controls.Add(label1);
            DragDropPanel.Location = new Point(12, 266);
            DragDropPanel.Name = "DragDropPanel";
            DragDropPanel.Size = new Size(642, 171);
            DragDropPanel.TabIndex = 0;
            DragDropPanel.Click += DragDropPanel_Click;
            DragDropPanel.DragDrop += DragDropPanel_DragDrop;
            DragDropPanel.DragEnter += DragDropPanel_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            label1.Location = new Point(169, 82);
            label1.Name = "label1";
            label1.Size = new Size(293, 28);
            label1.TabIndex = 3;
            label1.Text = "Click or drag to select replay file";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Version 2.0 exe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Version 2.1 exe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Version 2.2 exe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 178);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 4;
            label5.Text = "Version 2.3 exe";
            // 
            // version2_0_exe
            // 
            version2_0_exe.Location = new Point(142, 21);
            version2_0_exe.Name = "version2_0_exe";
            version2_0_exe.Size = new Size(316, 23);
            version2_0_exe.TabIndex = 5;
            version2_0_exe.Click += version2_0_exe_Click;
            // 
            // version2_1_exe
            // 
            version2_1_exe.Location = new Point(142, 74);
            version2_1_exe.Name = "version2_1_exe";
            version2_1_exe.Size = new Size(316, 23);
            version2_1_exe.TabIndex = 6;
            version2_1_exe.Click += version2_1_exe_Click;
            // 
            // version2_2_exe
            // 
            version2_2_exe.Location = new Point(142, 126);
            version2_2_exe.Name = "version2_2_exe";
            version2_2_exe.Size = new Size(316, 23);
            version2_2_exe.TabIndex = 7;
            version2_2_exe.Click += version2_2_exe_Click;
            // 
            // version2_3_exe
            // 
            version2_3_exe.Location = new Point(142, 175);
            version2_3_exe.Name = "version2_3_exe";
            version2_3_exe.Size = new Size(316, 23);
            version2_3_exe.TabIndex = 8;
            version2_3_exe.Click += version2_3_exe_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 220);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 9;
            label6.Text = "Additional args";
            // 
            // additionalArgs
            // 
            additionalArgs.Location = new Point(142, 217);
            additionalArgs.Name = "additionalArgs";
            additionalArgs.Size = new Size(316, 23);
            additionalArgs.TabIndex = 10;
            // 
            // RingRacerDemoLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 460);
            Controls.Add(additionalArgs);
            Controls.Add(label6);
            Controls.Add(version2_3_exe);
            Controls.Add(version2_2_exe);
            Controls.Add(version2_1_exe);
            Controls.Add(version2_0_exe);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DragDropPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RingRacerDemoLoader";
            Text = "Ring Racer Demo Loader";
            Load += RingRacerDemoLoader_Load;
            DragDropPanel.ResumeLayout(false);
            DragDropPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel DragDropPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox version2_0_exe;
        private TextBox version2_1_exe;
        private TextBox version2_2_exe;
        private TextBox version2_3_exe;
        private ImageList imageList1;
        private Label label6;
        private TextBox additionalArgs;
    }
}
