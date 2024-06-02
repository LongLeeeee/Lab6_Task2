namespace Lab6
{
    partial class client2
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
            this.name = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.notifromServer = new System.Windows.Forms.RichTextBox();
            this.numbers = new System.Windows.Forms.RichTextBox();
            this.time = new System.Windows.Forms.Label();
            this.endNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.turn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(335, 786);
            this.name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(185, 48);
            this.name.TabIndex = 0;
            this.name.Text = "Unknown";
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(475, 844);
            this.answer.Margin = new System.Windows.Forms.Padding(6);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(539, 56);
            this.answer.TabIndex = 1;
            this.answer.TextChanged += new System.EventHandler(this.answer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 850);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số bạn muốn chọn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 786);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên người chơi: ";
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new System.Drawing.Point(1124, 819);
            this.send.Margin = new System.Windows.Forms.Padding(6);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(222, 87);
            this.send.TabIndex = 4;
            this.send.Text = "Gửi";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // notifromServer
            // 
            this.notifromServer.Location = new System.Drawing.Point(39, 111);
            this.notifromServer.Margin = new System.Windows.Forms.Padding(6);
            this.notifromServer.Name = "notifromServer";
            this.notifromServer.ReadOnly = true;
            this.notifromServer.Size = new System.Drawing.Size(975, 639);
            this.notifromServer.TabIndex = 5;
            this.notifromServer.Text = "";
            // 
            // numbers
            // 
            this.numbers.Location = new System.Drawing.Point(1044, 111);
            this.numbers.Margin = new System.Windows.Forms.Padding(6);
            this.numbers.Name = "numbers";
            this.numbers.ReadOnly = true;
            this.numbers.Size = new System.Drawing.Size(372, 639);
            this.numbers.TabIndex = 6;
            this.numbers.Text = "";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(1134, 13);
            this.time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(197, 79);
            this.time.TabIndex = 14;
            this.time.Text = "00:00";
            // 
            // endNumber
            // 
            this.endNumber.AutoSize = true;
            this.endNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endNumber.Location = new System.Drawing.Point(957, 46);
            this.endNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.endNumber.Name = "endNumber";
            this.endNumber.Size = new System.Drawing.Size(41, 48);
            this.endNumber.TabIndex = 18;
            this.endNumber.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(865, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 48);
            this.label5.TabIndex = 17;
            this.label5.Text = "đến";
            // 
            // startNumber
            // 
            this.startNumber.AutoSize = true;
            this.startNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startNumber.Location = new System.Drawing.Point(803, 46);
            this.startNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.startNumber.Name = "startNumber";
            this.startNumber.Size = new System.Drawing.Size(41, 48);
            this.startNumber.TabIndex = 16;
            this.startNumber.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 48);
            this.label1.TabIndex = 15;
            this.label1.Text = "Phạm vi số cần tìm: ";
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn.Location = new System.Drawing.Point(149, 46);
            this.turn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(41, 48);
            this.turn.TabIndex = 20;
            this.turn.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 48);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lượt:  ";
            // 
            // client2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1443, 946);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.notifromServer);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "client2";
            this.Text = "client2";
            this.Load += new System.EventHandler(this.client2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.RichTextBox notifromServer;
        private System.Windows.Forms.RichTextBox numbers;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label endNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label startNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.Label label4;
    }
}