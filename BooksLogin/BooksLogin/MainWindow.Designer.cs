namespace BooksLogin
{
    partial class MainWindow
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
            this.listBox_List = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_List = new System.Windows.Forms.Button();
            this.listBox_byid = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Listbyid = new System.Windows.Forms.Button();
            this.textBox_besz_name = new System.Windows.Forms.TextBox();
            this.textBox_besz_length = new System.Windows.Forms.TextBox();
            this.textBox_besz_releaseyear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_rating = new System.Windows.Forms.TextBox();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.textBox_releaseYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_del_id = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.textBox_byid_id = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_like = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button_like = new System.Windows.Forms.Button();
            this.button_dislike = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_List
            // 
            this.listBox_List.FormattingEnabled = true;
            this.listBox_List.Location = new System.Drawing.Point(312, 36);
            this.listBox_List.Name = "listBox_List";
            this.listBox_List.Size = new System.Drawing.Size(310, 290);
            this.listBox_List.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listázás";
            // 
            // Button_List
            // 
            this.Button_List.Location = new System.Drawing.Point(423, 331);
            this.Button_List.Name = "Button_List";
            this.Button_List.Size = new System.Drawing.Size(75, 23);
            this.Button_List.TabIndex = 2;
            this.Button_List.Text = "Listázás";
            this.Button_List.UseVisualStyleBackColor = true;
            this.Button_List.Click += new System.EventHandler(this.Button_List_Click);
            // 
            // listBox_byid
            // 
            this.listBox_byid.FormattingEnabled = true;
            this.listBox_byid.Location = new System.Drawing.Point(3, 35);
            this.listBox_byid.Name = "listBox_byid";
            this.listBox_byid.Size = new System.Drawing.Size(289, 43);
            this.listBox_byid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(83, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id szerinti lekérés";
            // 
            // button_Listbyid
            // 
            this.button_Listbyid.Location = new System.Drawing.Point(151, 84);
            this.button_Listbyid.Name = "button_Listbyid";
            this.button_Listbyid.Size = new System.Drawing.Size(75, 23);
            this.button_Listbyid.TabIndex = 5;
            this.button_Listbyid.Text = "Lekérés";
            this.button_Listbyid.UseVisualStyleBackColor = true;
            this.button_Listbyid.Click += new System.EventHandler(this.Button_Listbyid_Click);
            // 
            // textBox_besz_name
            // 
            this.textBox_besz_name.Location = new System.Drawing.Point(97, 189);
            this.textBox_besz_name.Name = "textBox_besz_name";
            this.textBox_besz_name.Size = new System.Drawing.Size(140, 20);
            this.textBox_besz_name.TabIndex = 6;
            this.textBox_besz_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_besz_length
            // 
            this.textBox_besz_length.Location = new System.Drawing.Point(97, 224);
            this.textBox_besz_length.Name = "textBox_besz_length";
            this.textBox_besz_length.Size = new System.Drawing.Size(140, 20);
            this.textBox_besz_length.TabIndex = 8;
            this.textBox_besz_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_besz_releaseyear
            // 
            this.textBox_besz_releaseyear.Location = new System.Drawing.Point(97, 260);
            this.textBox_besz_releaseyear.Name = "textBox_besz_releaseyear";
            this.textBox_besz_releaseyear.Size = new System.Drawing.Size(140, 20);
            this.textBox_besz_releaseyear.TabIndex = 9;
            this.textBox_besz_releaseyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cím";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(110, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Beszúrás";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(298, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 392);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Oldalszám";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kiadási év";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(114, 302);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 15;
            this.button_Add.Text = "Beszúrás";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(627, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 392);
            this.panel2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(747, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Frissítés";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(720, 36);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(164, 20);
            this.textBox_id.TabIndex = 17;
            this.textBox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(720, 68);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(164, 20);
            this.textBox_name.TabIndex = 18;
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_rating
            // 
            this.textBox_rating.Enabled = false;
            this.textBox_rating.Location = new System.Drawing.Point(720, 100);
            this.textBox_rating.Name = "textBox_rating";
            this.textBox_rating.Size = new System.Drawing.Size(164, 20);
            this.textBox_rating.TabIndex = 19;
            this.textBox_rating.Text = "0";
            this.textBox_rating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(720, 132);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(164, 20);
            this.textBox_length.TabIndex = 20;
            this.textBox_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_releaseYear
            // 
            this.textBox_releaseYear.Location = new System.Drawing.Point(720, 162);
            this.textBox_releaseYear.Name = "textBox_releaseYear";
            this.textBox_releaseYear.Size = new System.Drawing.Size(164, 20);
            this.textBox_releaseYear.TabIndex = 21;
            this.textBox_releaseYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(656, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cím";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(640, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Oldalszám";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(661, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(642, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Pontszám";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(637, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Kiadás éve";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(742, 186);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 27;
            this.button_Update.Text = "Frissítés";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(737, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "Törlés";
            // 
            // textBox_del_id
            // 
            this.textBox_del_id.Location = new System.Drawing.Point(696, 259);
            this.textBox_del_id.Name = "textBox_del_id";
            this.textBox_del_id.Size = new System.Drawing.Size(98, 20);
            this.textBox_del_id.TabIndex = 29;
            this.textBox_del_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(661, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "ID";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(800, 258);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 31;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Logout.Location = new System.Drawing.Point(376, 360);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(157, 30);
            this.button_Logout.TabIndex = 32;
            this.button_Logout.Text = "Kijelentkezés";
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.Button_Logout_Click);
            // 
            // textBox_byid_id
            // 
            this.textBox_byid_id.Location = new System.Drawing.Point(55, 87);
            this.textBox_byid_id.Name = "textBox_byid_id";
            this.textBox_byid_id.Size = new System.Drawing.Size(72, 20);
            this.textBox_byid_id.TabIndex = 33;
            this.textBox_byid_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(19, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = "ID";
            // 
            // textBox_like
            // 
            this.textBox_like.Location = new System.Drawing.Point(758, 343);
            this.textBox_like.Name = "textBox_like";
            this.textBox_like.Size = new System.Drawing.Size(31, 20);
            this.textBox_like.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(724, 298);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 25);
            this.label16.TabIndex = 36;
            this.label16.Text = "Pontozás";
            // 
            // button_like
            // 
            this.button_like.Location = new System.Drawing.Point(664, 343);
            this.button_like.Name = "button_like";
            this.button_like.Size = new System.Drawing.Size(75, 23);
            this.button_like.TabIndex = 37;
            this.button_like.Text = "Tetszik";
            this.button_like.UseVisualStyleBackColor = true;
            this.button_like.Click += new System.EventHandler(this.Button_like_Click);
            // 
            // button_dislike
            // 
            this.button_dislike.Location = new System.Drawing.Point(809, 341);
            this.button_dislike.Name = "button_dislike";
            this.button_dislike.Size = new System.Drawing.Size(75, 23);
            this.button_dislike.TabIndex = 38;
            this.button_dislike.Text = "Nem tetszik";
            this.button_dislike.UseVisualStyleBackColor = true;
            this.button_dislike.Click += new System.EventHandler(this.Button_dislike_Click);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_login.Location = new System.Drawing.Point(367, 356);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(186, 34);
            this.button_login.TabIndex = 39;
            this.button_login.Text = "Bejelentkezés";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_dislike);
            this.Controls.Add(this.button_like);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox_like);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox_byid_id);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_del_id);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_releaseYear);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.textBox_rating);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_besz_releaseyear);
            this.Controls.Add(this.textBox_besz_length);
            this.Controls.Add(this.textBox_besz_name);
            this.Controls.Add(this.button_Listbyid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_byid);
            this.Controls.Add(this.Button_List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_List);
            this.Name = "MainWindow";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_List;
        private System.Windows.Forms.ListBox listBox_byid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Listbyid;
        private System.Windows.Forms.TextBox textBox_besz_name;
        private System.Windows.Forms.TextBox textBox_besz_length;
        private System.Windows.Forms.TextBox textBox_besz_releaseyear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_rating;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.TextBox textBox_releaseYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_del_id;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.TextBox textBox_byid_id;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_like;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_like;
        private System.Windows.Forms.Button button_dislike;
        private System.Windows.Forms.Button button_login;
    }
}