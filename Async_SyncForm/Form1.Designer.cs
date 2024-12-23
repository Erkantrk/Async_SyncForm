namespace Async_SyncForm
{
    partial class Form1
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
            pnlButtons = new Panel();
            lblTime = new Label();
            btnStep9 = new Button();
            btnStep8 = new Button();
            btnStep4 = new Button();
            btnStep7 = new Button();
            btnStep3 = new Button();
            btnStep6 = new Button();
            btnStep2 = new Button();
            btnStep5 = new Button();
            btnStep1 = new Button();
            lst_logbox = new ListBox();
            btn_sync = new Button();
            btn_async = new Button();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(lblTime);
            pnlButtons.Controls.Add(btnStep9);
            pnlButtons.Controls.Add(btnStep8);
            pnlButtons.Controls.Add(btnStep4);
            pnlButtons.Controls.Add(btnStep7);
            pnlButtons.Controls.Add(btnStep3);
            pnlButtons.Controls.Add(btnStep6);
            pnlButtons.Controls.Add(btnStep2);
            pnlButtons.Controls.Add(btnStep5);
            pnlButtons.Controls.Add(btnStep1);
            pnlButtons.Location = new Point(564, 1);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(233, 448);
            pnlButtons.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTime.Location = new Point(11, 407);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(219, 33);
            lblTime.TabIndex = 9;
            lblTime.Text = "         Zaman";
            // 
            // btnStep9
            // 
            btnStep9.Location = new Point(3, 319);
            btnStep9.Name = "btnStep9";
            btnStep9.Size = new Size(227, 31);
            btnStep9.TabIndex = 8;
            btnStep9.Text = "Servis Et";
            btnStep9.UseVisualStyleBackColor = true;
            // 
            // btnStep8
            // 
            btnStep8.Location = new Point(3, 280);
            btnStep8.Name = "btnStep8";
            btnStep8.Size = new Size(227, 33);
            btnStep8.TabIndex = 7;
            btnStep8.Text = "Pişir";
            btnStep8.UseVisualStyleBackColor = true;
            // 
            // btnStep4
            // 
            btnStep4.Location = new Point(3, 120);
            btnStep4.Name = "btnStep4";
            btnStep4.Size = new Size(227, 33);
            btnStep4.TabIndex = 3;
            btnStep4.Text = "Ocağı Aç";
            btnStep4.UseVisualStyleBackColor = true;
            // 
            // btnStep7
            // 
            btnStep7.Location = new Point(3, 241);
            btnStep7.Name = "btnStep7";
            btnStep7.Size = new Size(227, 33);
            btnStep7.TabIndex = 6;
            btnStep7.Text = "Yumurtayı Ekle";
            btnStep7.UseVisualStyleBackColor = true;
            // 
            // btnStep3
            // 
            btnStep3.Location = new Point(3, 82);
            btnStep3.Name = "btnStep3";
            btnStep3.Size = new Size(227, 33);
            btnStep3.TabIndex = 2;
            btnStep3.Text = "Tuz Ekle";
            btnStep3.UseVisualStyleBackColor = true;
            // 
            // btnStep6
            // 
            btnStep6.Location = new Point(3, 199);
            btnStep6.Name = "btnStep6";
            btnStep6.Size = new Size(227, 36);
            btnStep6.TabIndex = 5;
            btnStep6.Text = "Yağı Dök";
            btnStep6.UseVisualStyleBackColor = true;
            // 
            // btnStep2
            // 
            btnStep2.Location = new Point(3, 42);
            btnStep2.Name = "btnStep2";
            btnStep2.Size = new Size(227, 36);
            btnStep2.TabIndex = 1;
            btnStep2.Text = "Yumurtaları Çırp";
            btnStep2.UseVisualStyleBackColor = true;
            // 
            // btnStep5
            // 
            btnStep5.Location = new Point(3, 159);
            btnStep5.Name = "btnStep5";
            btnStep5.Size = new Size(227, 34);
            btnStep5.TabIndex = 4;
            btnStep5.Text = "Tavayı Isıt";
            btnStep5.UseVisualStyleBackColor = true;
            // 
            // btnStep1
            // 
            btnStep1.Location = new Point(3, 3);
            btnStep1.Name = "btnStep1";
            btnStep1.Size = new Size(227, 34);
            btnStep1.TabIndex = 0;
            btnStep1.Text = "Yumurtaları Kır";
            btnStep1.UseVisualStyleBackColor = true;
            // 
            // lst_logbox
            // 
            lst_logbox.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lst_logbox.FormattingEnabled = true;
            lst_logbox.ItemHeight = 18;
            lst_logbox.Location = new Point(1, 176);
            lst_logbox.Name = "lst_logbox";
            lst_logbox.Size = new Size(557, 274);
            lst_logbox.TabIndex = 1;
            // 
            // btn_sync
            // 
            btn_sync.Location = new Point(50, 22);
            btn_sync.Name = "btn_sync";
            btn_sync.Size = new Size(308, 61);
            btn_sync.TabIndex = 2;
            btn_sync.Text = "Senkron Çalışma";
            btn_sync.UseVisualStyleBackColor = true;
            btn_sync.Click += btn_sync_Click;
            // 
            // btn_async
            // 
            btn_async.Location = new Point(50, 107);
            btn_async.Name = "btn_async";
            btn_async.Size = new Size(308, 61);
            btn_async.TabIndex = 2;
            btn_async.Text = "Asenkron Çalışma";
            btn_async.UseVisualStyleBackColor = true;
            btn_async.Click += btn_async_ClickAsync;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_async);
            Controls.Add(btn_sync);
            Controls.Add(lst_logbox);
            Controls.Add(pnlButtons);
            Name = "Form1";
            Text = "Form1";
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlButtons;
        private ListBox lst_logbox;
        private Button btn_sync;
        private Button btn_async;
        private Button btnStep9;
        private Button btnStep8;
        private Button btnStep4;
        private Button btnStep7;
        private Button btnStep3;
        private Button btnStep6;
        private Button btnStep2;
        private Button btnStep5;
        private Button btnStep1;
        private Label lblTime;
    }
}
