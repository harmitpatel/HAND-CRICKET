using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class mono_gmail : MonoBehaviour
{
    PlayerNameInputTaker m_playerNameInputTakerObj;
    void Start()
    {
         m_playerNameInputTakerObj =  GetComponent<PlayerNameInputTaker>();
    }

    string msg1 = string.Empty;
    string msg2 = string.Empty;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("harmitster@gmail.com");
            mail.To.Add(m_playerNameInputTakerObj.m_sInputEmail);
            mail.Subject = "New High Score in Leap Motion Fruit Tapper game";
            msg1 = "Dear " + m_playerNameInputTakerObj.m_sInputName;
            msg2 = ". There is a new high score. Play the game to beat his score.";
            mail.Body = msg1 + msg2;

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("navjotwarade@gmail.com", "navjot0724") as ICredentialsByHost;
            smtpServer.EnableSsl = true;
            ServicePointManager.ServerCertificateValidationCallback =
                delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                { return true; };
            smtpServer.Send(mail);
            Debug.Log("success");
        }
    }
}