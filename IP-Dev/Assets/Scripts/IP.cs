﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using TMPro;


public class IP : MonoBehaviour
{
    public TMP_Text IPTxt;

    public void button()
    {
        IPHostEntry host;
        string localIP = "?";
        host = Dns.GetHostEntry(Dns.GetHostName());

        foreach (IPAddress ip in host.AddressList)
        {
            if (ip.AddressFamily.ToString() == "InterNetwork")
            {
                localIP = ip.ToString();
                Debug.Log(localIP);

                IPTxt.text = localIP;
            }
        }
    }
}
