namespace GigPlanner
{
    partial class FestivalPlanner
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
            btnCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            lblSubtotal = new Label();
            lblResult = new Label();
            cboVenue = new ComboBox();
            cboAttendance = new ComboBox();
            radCamping = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(126, 122);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 23);
            label1.Name = "label1";
            label1.Size = new Size(46, 17);
            label1.TabIndex = 4;
            label1.Text = "Venue:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 42);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 5;
            label2.Text = "Attendance:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BorderStyle = BorderStyle.Fixed3D;
            lblSubtotal.Location = new Point(130, 77);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 17);
            lblSubtotal.TabIndex = 6;
            lblSubtotal.Text = "SubTotal";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(126, 148);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(46, 17);
            lblResult.TabIndex = 7;
            lblResult.Text = "Results";
            // 
            // cboVenue
            // 
            cboVenue.AllowDrop = true;
            cboVenue.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVenue.FormattingEnabled = true;
            cboVenue.Items.AddRange(new object[] { "Beyond Wonderland The Gorge", "Beyond Wonderland SoCal", "Beyond Wonderland Chicago", "Electric Daisy Carnival Las Vegas", "Electric Daisy Carnival Orlando", "Electric Daisy Carnival International" });
            cboVenue.Location = new Point(130, 17);
            cboVenue.Name = "cboVenue";
            cboVenue.Size = new Size(226, 23);
            cboVenue.TabIndex = 8;
            // 
            // cboAttendance
            // 
            cboAttendance.FormattingEnabled = true;
            cboAttendance.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboAttendance.Location = new Point(130, 42);
            cboAttendance.Name = "cboAttendance";
            cboAttendance.Size = new Size(32, 23);
            cboAttendance.TabIndex = 9;
            cboAttendance.SelectedIndexChanged += cboAttendance_SelectedIndexChanged;
            // 
            // radCamping
            // 
            radCamping.AutoSize = true;
            radCamping.Location = new Point(126, 97);
            radCamping.Name = "radCamping";
            radCamping.Size = new Size(79, 19);
            radCamping.TabIndex = 10;
            radCamping.TabStop = true;
            radCamping.Text = "Camping?";
            radCamping.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(207, 122);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // FestivalPlanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(408, 206);
            Controls.Add(button1);
            Controls.Add(radCamping);
            Controls.Add(cboAttendance);
            Controls.Add(cboVenue);
            Controls.Add(lblResult);
            Controls.Add(lblSubtotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FestivalPlanner";
            Text = "Festival Planner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTicketPrice;
        private Button btnCalculate;
        private Label label1;
        private Label label2;
        private Label lblSubtotal;
        private Label lblResult;
        private ComboBox cboVenue;
        private ComboBox cboAttendance;
        private RadioButton radCamping;
        private Button button1;
    }
}
