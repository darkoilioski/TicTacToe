namespace x_O
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
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            B3 = new Button();
            B2 = new Button();
            B1 = new Button();
            C3 = new Button();
            C2 = new Button();
            C1 = new Button();
            playerX = new Label();
            resultX = new Label();
            VS = new Label();
            result0 = new Label();
            player0 = new Label();
            title = new Label();
            newGame = new Button();
            resetResult = new Button();
            exitForm = new Button();
            SuspendLayout();
            // 
            // A1
            // 
            A1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            A1.Location = new Point(235, 131);
            A1.Name = "A1";
            A1.Size = new Size(75, 75);
            A1.TabIndex = 1;
            A1.UseVisualStyleBackColor = true;
            A1.Click += button_click;
            // 
            // A2
            // 
            A2.Location = new Point(355, 131);
            A2.Name = "A2";
            A2.Size = new Size(75, 75);
            A2.TabIndex = 2;
            A2.UseVisualStyleBackColor = true;
            A2.Click += button_click;
            // 
            // A3
            // 
            A3.Location = new Point(474, 131);
            A3.Name = "A3";
            A3.Size = new Size(75, 75);
            A3.TabIndex = 3;
            A3.UseVisualStyleBackColor = true;
            A3.Click += button_click;
            // 
            // B3
            // 
            B3.Location = new Point(474, 242);
            B3.Name = "B3";
            B3.Size = new Size(75, 75);
            B3.TabIndex = 6;
            B3.UseVisualStyleBackColor = true;
            B3.Click += button_click;
            // 
            // B2
            // 
            B2.Location = new Point(355, 242);
            B2.Name = "B2";
            B2.Size = new Size(75, 75);
            B2.TabIndex = 5;
            B2.UseVisualStyleBackColor = true;
            B2.Click += button_click;
            // 
            // B1
            // 
            B1.Location = new Point(235, 242);
            B1.Name = "B1";
            B1.Size = new Size(75, 75);
            B1.TabIndex = 4;
            B1.UseVisualStyleBackColor = true;
            B1.Click += button_click;
            // 
            // C3
            // 
            C3.Location = new Point(474, 353);
            C3.Name = "C3";
            C3.Size = new Size(75, 75);
            C3.TabIndex = 9;
            C3.UseVisualStyleBackColor = true;
            C3.Click += button_click;
            // 
            // C2
            // 
            C2.Location = new Point(355, 353);
            C2.Name = "C2";
            C2.Size = new Size(75, 75);
            C2.TabIndex = 8;
            C2.UseVisualStyleBackColor = true;
            C2.Click += button_click;
            // 
            // C1
            // 
            C1.Location = new Point(235, 353);
            C1.Name = "C1";
            C1.Size = new Size(75, 75);
            C1.TabIndex = 7;
            C1.UseVisualStyleBackColor = true;
            C1.Click += button_click;
            // 
            // playerX
            // 
            playerX.AutoSize = true;
            playerX.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            playerX.Location = new Point(17, 72);
            playerX.Name = "playerX";
            playerX.Size = new Size(124, 38);
            playerX.TabIndex = 10;
            playerX.Text = "Player: X";
            // 
            // resultX
            // 
            resultX.AutoSize = true;
            resultX.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultX.Location = new Point(147, 72);
            resultX.Name = "resultX";
            resultX.Size = new Size(32, 38);
            resultX.TabIndex = 11;
            resultX.Text = "0";
            // 
            // VS
            // 
            VS.AutoSize = true;
            VS.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            VS.Location = new Point(338, 72);
            VS.Name = "VS";
            VS.Size = new Size(49, 38);
            VS.TabIndex = 12;
            VS.Text = "VS";
            // 
            // result0
            // 
            result0.AutoSize = true;
            result0.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            result0.Location = new Point(528, 72);
            result0.Name = "result0";
            result0.Size = new Size(32, 38);
            result0.TabIndex = 13;
            result0.Text = "0";
            // 
            // player0
            // 
            player0.AutoSize = true;
            player0.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            player0.Location = new Point(658, 72);
            player0.Name = "player0";
            player0.Size = new Size(122, 38);
            player0.TabIndex = 14;
            player0.Text = "Player: 0";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(261, 21);
            title.Name = "title";
            title.Size = new Size(180, 20);
            title.TabIndex = 15;
            title.Text = "X or 0. Game for 2 players";
            // 
            // newGame
            // 
            newGame.Location = new Point(17, 154);
            newGame.Name = "newGame";
            newGame.Size = new Size(94, 29);
            newGame.TabIndex = 16;
            newGame.Text = "New game";
            newGame.UseVisualStyleBackColor = true;
            newGame.Click += newGame_Click;
            // 
            // resetResult
            // 
            resetResult.Location = new Point(658, 154);
            resetResult.Name = "resetResult";
            resetResult.Size = new Size(94, 29);
            resetResult.TabIndex = 17;
            resetResult.Text = "Reset result";
            resetResult.UseVisualStyleBackColor = true;
            resetResult.Click += resetResult_Click;
            // 
            // exitForm
            // 
            exitForm.Location = new Point(669, 429);
            exitForm.Name = "exitForm";
            exitForm.Size = new Size(94, 29);
            exitForm.TabIndex = 18;
            exitForm.Text = "Exit";
            exitForm.UseVisualStyleBackColor = true;
            exitForm.Click += exitForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 480);
            Controls.Add(exitForm);
            Controls.Add(resetResult);
            Controls.Add(newGame);
            Controls.Add(title);
            Controls.Add(player0);
            Controls.Add(result0);
            Controls.Add(VS);
            Controls.Add(resultX);
            Controls.Add(playerX);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Name = "Form1";
            ShowIcon = false;
            Text = "X or O";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button A1;
        private Button A2;
        private Button A3;
        private Button B3;
        private Button B2;
        private Button button6;
        private Button C3;
        private Button C2;
        private Button C1;
        private Button B1;
        private Label playerX;
        private Label resultX;
        private Label VS;
        private Label result0;
        private Label player0;
        private Label title;
        private Button newGame;
        private Button resetResult;
        private Button exitForm;
    }
}
