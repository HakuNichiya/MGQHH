using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonSet : MonoBehaviour
{
    public SettingsData ST;

    public bool Up;
    public bool Down;
    public bool Left;
    public bool Right;
    public void Update()
    {
        if (Up)
        {
            GetComponent<Text>().text = "¬верх - " + ST.MS.Up.ToString();
        }
        if (Down)
        {
            GetComponent<Text>().text = "¬низ - " +  ST.MS.Down.ToString();
        }
        if (Left)
        {
            GetComponent<Text>().text = "¬лево - " + ST.MS.Left.ToString();
        }
        if (Right)
        {
            GetComponent<Text>().text = "¬право - " + ST.MS.Right.ToString();
        }
    }

    public IEnumerator WaitForKeyDown()
    {
        while (!Input.anyKey)
        {
            yield return null;
        }
        SB();
    }

    public void SetButon()
    {
        StartCoroutine(WaitForKeyDown());
    }

    public void SB()
    {
        
        KeyCode R = new KeyCode();

        if (Input.GetKey(KeyCode.None))
        {
            R = KeyCode.None;
        }
        else if (Input.GetKey(KeyCode.Backspace))
        {
            R = KeyCode.Backspace;
        }
        else if (Input.GetKey(KeyCode.Delete))
        {
            R = KeyCode.Delete;
        }
        else if (Input.GetKey(KeyCode.Tab))
        {
            R = KeyCode.Tab;
        }
        else if (Input.GetKey(KeyCode.Clear))
        {
            R = KeyCode.Clear;
        }
        else if (Input.GetKey(KeyCode.Return))
        {
            R = KeyCode.Return;
        }
        else if (Input.GetKey(KeyCode.Pause))
        {
            R = KeyCode.Pause;
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            R = KeyCode.Escape;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            R = KeyCode.Space;
        }
        else if (Input.GetKey(KeyCode.Keypad0))
        {
            R = KeyCode.Keypad0;
        }
        else if (Input.GetKey(KeyCode.Keypad1))
        {
            R = KeyCode.Keypad1;
        }
        else if (Input.GetKey(KeyCode.Keypad2))
        {
            R = KeyCode.Keypad2;
        }
        else if (Input.GetKey(KeyCode.Keypad3))
        {
            R = KeyCode.Keypad3;
        }
        else if (Input.GetKey(KeyCode.Keypad4))
        {
            R = KeyCode.Keypad4;
        }
        else if (Input.GetKey(KeyCode.Keypad5))
        {
            R = KeyCode.Keypad5;
        }
        else if (Input.GetKey(KeyCode.Keypad6))
        {
            R = KeyCode.Keypad6;
        }
        else if (Input.GetKey(KeyCode.Keypad7))
        {
            R = KeyCode.Keypad7;
        }
        else if (Input.GetKey(KeyCode.Keypad8))
        {
            R = KeyCode.Keypad8;
        }
        else if (Input.GetKey(KeyCode.Keypad9))
        {
            R = KeyCode.Keypad9;
        }
        else if (Input.GetKey(KeyCode.KeypadPeriod))
        {
            R = KeyCode.KeypadPeriod;
        }
        else if (Input.GetKey(KeyCode.KeypadDivide))
        {
            R = KeyCode.KeypadDivide;
        }
        else if (Input.GetKey(KeyCode.KeypadMultiply))
        {
            R = KeyCode.KeypadMultiply;
        }
        else if (Input.GetKey(KeyCode.KeypadMinus))
        {
            R = KeyCode.KeypadMinus;
        }
        else if (Input.GetKey(KeyCode.KeypadPlus))
        {
            R = KeyCode.KeypadPlus;
        }
        else if (Input.GetKey(KeyCode.KeypadEnter))
        {
            R = KeyCode.KeypadEnter;
        }
        else if (Input.GetKey(KeyCode.Home))
        {
            R = KeyCode.Home;
        }
        else if (Input.GetKey(KeyCode.End))
        {
            R = KeyCode.End;
        }
        else if (Input.GetKey(KeyCode.PageUp))
        {
            R = KeyCode.PageUp;
        }
        else if (Input.GetKey(KeyCode.PageDown))
        {
            R = KeyCode.PageDown;
        }
        else if (Input.GetKey(KeyCode.F1))
        {
            R = KeyCode.F1;
        }
        else if (Input.GetKey(KeyCode.F2))
        {
            R = KeyCode.F2;
        }
        else if (Input.GetKey(KeyCode.F3))
        {
            R = KeyCode.F3;
        }
        else if (Input.GetKey(KeyCode.F4))
        {
            R = KeyCode.F4;
        }
        else if (Input.GetKey(KeyCode.F5))
        {
            R = KeyCode.F5;
        }
        else if (Input.GetKey(KeyCode.F6))
        {
            R = KeyCode.F6;
        }
        else if (Input.GetKey(KeyCode.F7))
        {
            R = KeyCode.F7;
        }
        else if (Input.GetKey(KeyCode.F8))
        {
            R = KeyCode.F8;
        }
        else if (Input.GetKey(KeyCode.F9))
        {
            R = KeyCode.F9;
        }
        else if (Input.GetKey(KeyCode.F10))
        {
            R = KeyCode.F10;
        }
        else if (Input.GetKey(KeyCode.F11))
        {
            R = KeyCode.F11;
        }
        else if (Input.GetKey(KeyCode.F12))
        {
            R = KeyCode.F12;
        }
        else if (Input.GetKey(KeyCode.F13))
        {
            R = KeyCode.F13;
        }
        else if (Input.GetKey(KeyCode.F14))
        {
            R = KeyCode.F14;
        }
        else if (Input.GetKey(KeyCode.F15))
        {
            R = KeyCode.F15;
        }
        else if (Input.GetKey(KeyCode.Alpha0))
        {
            R = KeyCode.Alpha0;
        }
        else if (Input.GetKey(KeyCode.Alpha1))
        {
            R = KeyCode.Alpha1;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            R = KeyCode.Alpha2;
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            R = KeyCode.Alpha3;
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            R = KeyCode.Alpha4;
        }
        else if (Input.GetKey(KeyCode.Alpha5))
        {
            R = KeyCode.Alpha5;
        }
        else if (Input.GetKey(KeyCode.Alpha6))
        {
            R = KeyCode.Alpha6;
        }
        else if (Input.GetKey(KeyCode.Alpha7))
        {
            R = KeyCode.Alpha7;
        }
        else if (Input.GetKey(KeyCode.Alpha8))
        {
            R = KeyCode.Alpha8;
        }
        else if (Input.GetKey(KeyCode.Alpha9))
        {
            R = KeyCode.Alpha9;
        }
        else if (Input.GetKey(KeyCode.Exclaim))
        {
            R = KeyCode.Exclaim;
        }
        else if (Input.GetKey(KeyCode.DoubleQuote))
        {
            R = KeyCode.DoubleQuote;
        }
        else if (Input.GetKey(KeyCode.Hash))
        {
            R = KeyCode.Hash;
        }
        else if (Input.GetKey(KeyCode.Dollar))
        {
            R = KeyCode.Dollar;
        }
        else if (Input.GetKey(KeyCode.Percent))
        {
            R = KeyCode.Percent;
        }
        else if (Input.GetKey(KeyCode.Ampersand))
        {
            R = KeyCode.Ampersand;
        }
        else if (Input.GetKey(KeyCode.Quote))
        {
            R = KeyCode.Quote;
        }
        else if (Input.GetKey(KeyCode.LeftParen))
        {
            R = KeyCode.LeftParen;
        }
        else if (Input.GetKey(KeyCode.RightParen))
        {
            R = KeyCode.RightParen;
        }
        else if (Input.GetKey(KeyCode.Asterisk))
        {
            R = KeyCode.Asterisk;
        }
        else if (Input.GetKey(KeyCode.Plus))
        {
            R = KeyCode.Plus;
        }
        else if (Input.GetKey(KeyCode.Minus))
        {
            R = KeyCode.Minus;
        }
        else if (Input.GetKey(KeyCode.Period))
        {
            R = KeyCode.Period;
        }
        else if (Input.GetKey(KeyCode.Slash))
        {
            R = KeyCode.Slash;
        }
        else if (Input.GetKey(KeyCode.Colon))
        {
            R = KeyCode.Colon;
        }
        else if (Input.GetKey(KeyCode.Semicolon))
        {
            R = KeyCode.Semicolon;
        }
        else if (Input.GetKey(KeyCode.Less))
        {
            R = KeyCode.Less;
        }
        else if (Input.GetKey(KeyCode.Equals))
        {
            R = KeyCode.Equals;
        }
        else if (Input.GetKey(KeyCode.Greater))
        {
            R = KeyCode.Greater;
        }
        else if (Input.GetKey(KeyCode.Question))
        {
            R = KeyCode.Question;
        }
        else if (Input.GetKey(KeyCode.At))
        {
            R = KeyCode.At;
        }
        else if (Input.GetKey(KeyCode.LeftBracket))
        {
            R = KeyCode.LeftBracket;
        }
        else if (Input.GetKey(KeyCode.Backslash))
        {
            R = KeyCode.Backslash;
        }
        else if (Input.GetKey(KeyCode.RightBracket))
        {
            R = KeyCode.RightBracket;
        }
        else if (Input.GetKey(KeyCode.Caret))
        {
            R = KeyCode.Caret;
        }
        else if (Input.GetKey(KeyCode.Underscore))
        {
            R = KeyCode.Underscore;
        }
        else if (Input.GetKey(KeyCode.BackQuote))
        {
            R = KeyCode.BackQuote;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            R = KeyCode.Q;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            R = KeyCode.W;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            R = KeyCode.E;
        }
        else if (Input.GetKey(KeyCode.R))
        {
            R = KeyCode.R;
        }
        else if (Input.GetKey(KeyCode.T))
        {
            R = KeyCode.T;
        }
        else if (Input.GetKey(KeyCode.Y))
        {
            R = KeyCode.Y;
        }
        else if (Input.GetKey(KeyCode.U))
        {
            R = KeyCode.U;
        }
        else if (Input.GetKey(KeyCode.I))
        {
            R = KeyCode.I;
        }
        else if (Input.GetKey(KeyCode.O))
        {
            R = KeyCode.O;
        }
        else if (Input.GetKey(KeyCode.P))
        {
            R = KeyCode.P;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            R = KeyCode.A;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            R = KeyCode.S;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            R = KeyCode.D;
        }
        else if (Input.GetKey(KeyCode.F))
        {
            R = KeyCode.F;
        }
        else if (Input.GetKey(KeyCode.G))
        {
            R = KeyCode.G;
        }
        else if (Input.GetKey(KeyCode.H))
        {
            R = KeyCode.H;
        }
        else if (Input.GetKey(KeyCode.J))
        {
            R = KeyCode.J;
        }
        else if (Input.GetKey(KeyCode.K))
        {
            R = KeyCode.K;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            R = KeyCode.L;
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            R = KeyCode.Z;
        }
        else if (Input.GetKey(KeyCode.X))
        {
            R = KeyCode.X;
        }
        else if (Input.GetKey(KeyCode.C))
        {
            R = KeyCode.C;
        }
        else if (Input.GetKey(KeyCode.V))
        {
            R = KeyCode.V;
        }
        else if (Input.GetKey(KeyCode.B))
        {
            R = KeyCode.B;
        }
        else if (Input.GetKey(KeyCode.N))
        {
            R = KeyCode.N;
        }
        else if (Input.GetKey(KeyCode.M))
        {
            R = KeyCode.M;
        }
        else if (Input.GetKey(KeyCode.LeftCurlyBracket))
        {
            R = KeyCode.LeftCurlyBracket;
        }
        else if (Input.GetKey(KeyCode.RightCurlyBracket))
        {
            R = KeyCode.RightCurlyBracket;
        }
        else if (Input.GetKey(KeyCode.Tilde))
        {
            R = KeyCode.Tilde;
        }
        else if (Input.GetKey(KeyCode.Numlock))
        {
            R = KeyCode.Numlock;
        }
        else if (Input.GetKey(KeyCode.CapsLock))
        {
            R = KeyCode.CapsLock;
        }
        else if (Input.GetKey(KeyCode.ScrollLock))
        {
            R = KeyCode.ScrollLock;
        }
        else if (Input.GetKey(KeyCode.RightShift))
        {
            R = KeyCode.RightShift;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            R = KeyCode.LeftShift;
        }
        else if (Input.GetKey(KeyCode.RightControl))
        {
            R = KeyCode.RightControl;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            R = KeyCode.LeftControl;
        }
        else if (Input.GetKey(KeyCode.RightAlt))
        {
            R = KeyCode.RightAlt;
        }
        else if (Input.GetKey(KeyCode.LeftAlt))
        {
            R = KeyCode.LeftAlt;
        }
        else if (Input.GetKey(KeyCode.LeftCommand))
        {
            R = KeyCode.LeftCommand;
        }
        else if (Input.GetKey(KeyCode.LeftApple))
        {
            R = KeyCode.LeftApple;
        }
        else if (Input.GetKey(KeyCode.LeftWindows))
        {
            R = KeyCode.LeftWindows;
        }
        else if (Input.GetKey(KeyCode.RightCommand))
        {
            R = KeyCode.RightCommand;
        }
        else if (Input.GetKey(KeyCode.RightApple))
        {
            R = KeyCode.RightApple;
        }
        else if (Input.GetKey(KeyCode.RightWindows))
        {
            R = KeyCode.RightWindows;
        }
        else if (Input.GetKey(KeyCode.AltGr))
        {
            R = KeyCode.AltGr;
        }
        else if (Input.GetKey(KeyCode.Help))
        {
            R = KeyCode.Help;
        }
        else if (Input.GetKey(KeyCode.Print))
        {
            R = KeyCode.Print;
        }
        else if (Input.GetKey(KeyCode.SysReq))
        {
            R = KeyCode.SysReq;
        }
        else if (Input.GetKey(KeyCode.Break))
        {
            R = KeyCode.Break;
        }
        else if (Input.GetKey(KeyCode.Menu))
        {
            R = KeyCode.Menu;
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            R = KeyCode.Mouse0;
        }
        else if (Input.GetKey(KeyCode.Mouse1))
        {
            R = KeyCode.Mouse1;
        }
        else if (Input.GetKey(KeyCode.Mouse2))
        {
            R = KeyCode.Mouse2;
        }
        else if (Input.GetKey(KeyCode.Mouse3))
        {
            R = KeyCode.Mouse3;
        }
        else if (Input.GetKey(KeyCode.Mouse4))
        {
            R = KeyCode.Mouse4;
        }
        else if (Input.GetKey(KeyCode.Mouse5))
        {
            R = KeyCode.Mouse5;
        }
        else if (Input.GetKey(KeyCode.Mouse6))
        {
            R = KeyCode.Mouse6;
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            R = KeyCode.UpArrow;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            R = KeyCode.DownArrow;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            R = KeyCode.LeftArrow;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            R = KeyCode.RightArrow;
        }

        if (Up)
        {
            ST.MS.Up = R;
        }
        else if (Down)
        {
            ST.MS.Down = R;
        }
        else if(Left)
        {
            ST.MS.Left = R;
        }
        else if(Right)
        {
            ST.MS.Right = R;
        }

        Debug.Log(R.ToString());
    }
}
