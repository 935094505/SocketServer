namespace SocketServer
{
    partial class FrmServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Start = new System.Windows.Forms.Button();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.btn_StopListen = new System.Windows.Forms.Button();
            this.cmb_Socket = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(395, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "开始监听";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(12, 14);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(195, 21);
            this.txt_IP.TabIndex = 1;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(262, 14);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(90, 21);
            this.txt_Port.TabIndex = 2;
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(12, 55);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(321, 224);
            this.txt_Log.TabIndex = 3;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(394, 313);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 25);
            this.btn_Select.TabIndex = 4;
            this.btn_Select.Text = "选择";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(12, 316);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(341, 21);
            this.txt_FilePath.TabIndex = 5;
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Location = new System.Drawing.Point(539, 314);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SendFile.TabIndex = 6;
            this.btn_SendFile.Text = "发送文件";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            this.btn_SendFile.Click += new System.EventHandler(this.btn_SendFile_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(394, 353);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 27);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "发送消息";
            this.btn_Send.UseVisualStyleBackColor = true;
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(351, 55);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(321, 224);
            this.txt_Msg.TabIndex = 8;
            // 
            // btn_StopListen
            // 
            this.btn_StopListen.Location = new System.Drawing.Point(489, 12);
            this.btn_StopListen.Name = "btn_StopListen";
            this.btn_StopListen.Size = new System.Drawing.Size(75, 23);
            this.btn_StopListen.TabIndex = 9;
            this.btn_StopListen.Text = "停止监听";
            this.btn_StopListen.UseVisualStyleBackColor = true;
            this.btn_StopListen.Click += new System.EventHandler(this.btn_StopListen_Click);
            // 
            // cmb_Socket
            // 
            this.cmb_Socket.FormattingEnabled = true;
            this.cmb_Socket.Location = new System.Drawing.Point(625, 15);
            this.cmb_Socket.Name = "cmb_Socket";
            this.cmb_Socket.Size = new System.Drawing.Size(121, 20);
            this.cmb_Socket.TabIndex = 10;
            // 
            // FrmServer
            // 
            this.ClientSize = new System.Drawing.Size(782, 428);
            this.Controls.Add(this.cmb_Socket);
            this.Controls.Add(this.btn_StopListen);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_SendFile);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.btn_Start);
            this.Name = "FrmServer";
            this.Text = "服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.Button btn_StopListen;
        private System.Windows.Forms.ComboBox cmb_Socket;
    }
}

