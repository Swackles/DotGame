namespace PlatformerGame1
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
            this.CreateCharacterBtn = new System.Windows.Forms.Button();
            this.Actions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateCharacterBtn
            // 
            this.CreateCharacterBtn.Location = new System.Drawing.Point(13, 13);
            this.CreateCharacterBtn.Name = "CreateCharacterBtn";
            this.CreateCharacterBtn.Size = new System.Drawing.Size(100, 23);
            this.CreateCharacterBtn.TabIndex = 0;
            this.CreateCharacterBtn.Text = "CreateCharacter";
            this.CreateCharacterBtn.UseVisualStyleBackColor = true;
            this.CreateCharacterBtn.Click += new System.EventHandler(this.CreateCharacterBtn_Click);
            // 
            // Actions
            // 
            this.Actions.Location = new System.Drawing.Point(13, 43);
            this.Actions.Multiline = true;
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            this.Actions.Size = new System.Drawing.Size(100, 406);
            this.Actions.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.CreateCharacterBtn);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_keyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCharacterBtn;
        private System.Windows.Forms.TextBox Actions;
    }
}

