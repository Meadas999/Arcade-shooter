
namespace Tester
{
    partial class Leaderboard
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
            this.terugKnop = new System.Windows.Forms.Button();
            this.MakeConnection = new System.Windows.Forms.Button();
            this.CloseConnectionBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // terugKnop
            // 
            this.terugKnop.Location = new System.Drawing.Point(38, 400);
            this.terugKnop.Name = "terugKnop";
            this.terugKnop.Size = new System.Drawing.Size(75, 23);
            this.terugKnop.TabIndex = 0;
            this.terugKnop.Text = "back";
            this.terugKnop.UseVisualStyleBackColor = true;
            this.terugKnop.Click += new System.EventHandler(this.terugKnop_Click);
            // 
            // MakeConnection
            // 
            this.MakeConnection.Location = new System.Drawing.Point(347, 100);
            this.MakeConnection.Name = "MakeConnection";
            this.MakeConnection.Size = new System.Drawing.Size(75, 23);
            this.MakeConnection.TabIndex = 1;
            this.MakeConnection.Text = "Open";
            this.MakeConnection.UseVisualStyleBackColor = true;
            this.MakeConnection.Click += new System.EventHandler(this.MakeConnection_Click);
            // 
            // CloseConnectionBTN
            // 
            this.CloseConnectionBTN.Location = new System.Drawing.Point(444, 100);
            this.CloseConnectionBTN.Name = "CloseConnectionBTN";
            this.CloseConnectionBTN.Size = new System.Drawing.Size(75, 23);
            this.CloseConnectionBTN.TabIndex = 2;
            this.CloseConnectionBTN.Text = "Close";
            this.CloseConnectionBTN.UseVisualStyleBackColor = true;
            this.CloseConnectionBTN.Click += new System.EventHandler(this.CloseConnectionBTN_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseConnectionBTN);
            this.Controls.Add(this.MakeConnection);
            this.Controls.Add(this.terugKnop);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button terugKnop;
        private System.Windows.Forms.Button MakeConnection;
        private System.Windows.Forms.Button CloseConnectionBTN;
    }
}