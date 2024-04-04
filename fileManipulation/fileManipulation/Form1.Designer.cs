namespace fileManipulation
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
            nameTextBox = new TextBox();
            createButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(213, 125);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(379, 27);
            nameTextBox.TabIndex = 0;
            // 
            // createButton
            // 
            createButton.Location = new Point(213, 204);
            createButton.Name = "createButton";
            createButton.Size = new Size(150, 70);
            createButton.TabIndex = 1;
            createButton.Text = "Create File";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(442, 204);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 70);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete File";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(createButton);
            Controls.Add(nameTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Button createButton;
        private Button deleteButton;
    }
}