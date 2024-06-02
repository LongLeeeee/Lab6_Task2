namespace Lab6
{
    partial class server
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
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.turn = new System.Windows.Forms.Label();
            this.Clients = new System.Windows.Forms.RichTextBox();
            this.notification = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_answer = new System.Windows.Forms.Label();
            this.numberOfClient = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(29, 39);
            this.start.Margin = new System.Windows.Forms.Padding(6);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(192, 77);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lượt:  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn.Location = new System.Drawing.Point(139, 152);
            this.turn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(41, 48);
            this.turn.TabIndex = 2;
            this.turn.Text = "0";
            this.turn.Click += new System.EventHandler(this.label2_Click);
            // 
            // Clients
            // 
            this.Clients.Location = new System.Drawing.Point(1449, 223);
            this.Clients.Margin = new System.Windows.Forms.Padding(6);
            this.Clients.Name = "Clients";
            this.Clients.ReadOnly = true;
            this.Clients.Size = new System.Drawing.Size(426, 650);
            this.Clients.TabIndex = 3;
            this.Clients.Text = "";
            // 
            // notification
            // 
            this.notification.Location = new System.Drawing.Point(35, 223);
            this.notification.Margin = new System.Windows.Forms.Padding(6);
            this.notification.Name = "notification";
            this.notification.ReadOnly = true;
            this.notification.Size = new System.Drawing.Size(965, 650);
            this.notification.TabIndex = 4;
            this.notification.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phạm vi số cần tìm: ";
            // 
            // startNumber
            // 
            this.startNumber.AutoSize = true;
            this.startNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startNumber.Location = new System.Drawing.Point(607, 39);
            this.startNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.startNumber.Name = "startNumber";
            this.startNumber.Size = new System.Drawing.Size(41, 48);
            this.startNumber.TabIndex = 6;
            this.startNumber.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(666, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 48);
            this.label5.TabIndex = 7;
            this.label5.Text = "đến";
            // 
            // endNumber
            // 
            this.endNumber.AutoSize = true;
            this.endNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endNumber.Location = new System.Drawing.Point(744, 39);
            this.endNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.endNumber.Name = "endNumber";
            this.endNumber.Size = new System.Drawing.Size(41, 48);
            this.endNumber.TabIndex = 8;
            this.endNumber.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 48);
            this.label7.TabIndex = 9;
            this.label7.Text = "Số cần tìm: ";
            // 
            // lb_answer
            // 
            this.lb_answer.AutoSize = true;
            this.lb_answer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_answer.Location = new System.Drawing.Point(463, 102);
            this.lb_answer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_answer.Name = "lb_answer";
            this.lb_answer.Size = new System.Drawing.Size(41, 48);
            this.lb_answer.TabIndex = 10;
            this.lb_answer.Text = "0";
            // 
            // numberOfClient
            // 
            this.numberOfClient.AutoSize = true;
            this.numberOfClient.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfClient.Location = new System.Drawing.Point(1808, 101);
            this.numberOfClient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numberOfClient.Name = "numberOfClient";
            this.numberOfClient.Size = new System.Drawing.Size(41, 48);
            this.numberOfClient.TabIndex = 12;
            this.numberOfClient.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1452, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(357, 48);
            this.label10.TabIndex = 11;
            this.label10.Text = "Số người tham gia: ";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(803, 75);
            this.time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(197, 79);
            this.time.TabIndex = 13;
            this.time.Text = "00:00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1452, 164);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(395, 48);
            this.label12.TabIndex = 14;
            this.label12.Text = "Danh sách người chơi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 223);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 48);
            this.label13.TabIndex = 15;
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(1033, 223);
            this.rank.Margin = new System.Windows.Forms.Padding(6);
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Size = new System.Drawing.Size(380, 650);
            this.rank.TabIndex = 16;
            this.rank.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1037, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 48);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bảng điểm";
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1903, 912);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.time);
            this.Controls.Add(this.numberOfClient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_answer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "server";
            this.Text = "server";
            this.Load += new System.EventHandler(this.server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.RichTextBox Clients;
        private System.Windows.Forms.RichTextBox notification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label startNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label endNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_answer;
        private System.Windows.Forms.Label numberOfClient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rank;
        private System.Windows.Forms.Label label2;
    }
}