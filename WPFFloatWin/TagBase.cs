﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace WPFFloatWin
{
    public class TagBase
    {
        protected TagWindow window;
        public TagWindow Window
        {
            get
            {
                return window;
            }
        }
        public TagBase(ref TagWindow host)
        {
            window = host;
        }
        private Canvas _cv;
        private bool _iscreated = false;
        Button _create_button;
        private int _Width;
        private int _Height;
        public int Width
        {
            get
            {
                return _Width;
            }
            set
            {
                window.ContentWidth = value;
                _Width = value;
            }
        }
        public int Height
        {
            get
            {
                return _Height;
            }
            set
            {
                window.ContentHeight = value;
                _Height = value;
            }
        }
        public bool IsCreated
        {
            get
            {
                return _iscreated;
            }
            set
            {
                _iscreated = value;
            }
        }
        public Canvas cv
        {
            get
            {
                return _cv;
            }
            set
            {
                _cv = value;
            }
        }
        
        public virtual Type[] CollideWith
        {
            get
            {
                return new Type[] { };
            }
        }

        public virtual string GetName()
        {
            return "None";
        }

        public virtual FrameworkElement[] DragMoveInvaild
        {
            get { return new FrameworkElement[] { }; }
        }


        public virtual bool CanCreateFromFile
        {
            get { return true; }
        }
        public virtual bool CanCreateNewFile
        {
            get { return true; }
        }
        public virtual bool RightClickActive
        {
            get { return true; }
        }
        public virtual void OnCreateFromFile(string filedata)
        {
            IsCreated = true;
        }
        public virtual void OnCreateNew()
        {
            IsCreated = true;
        }
        public virtual void OnInit()
        {
            if (!IsCreated)
            {
                Width = 300;
                Height = 50;
                _create_button = new Button();
                _create_button.Style = window.FindResource("btnstyle") as Style;
                _create_button.FontFamily = new FontFamily("Agency FB");
                _create_button.FontSize = 36;
                _create_button.Width = 80;
                _create_button.Height = 40;
                _create_button.BorderBrush = null;
                _create_button.Content = "Create";
                _create_button.Margin = new Thickness(104, 0, 0, 0);
                _create_button.Background = new SolidColorBrush(Color.FromArgb(1, 0, 0, 0));
                window.tw_content.Children.Add(_create_button);
                _create_button.Click += (s, e) => { ClickFunc(); };
            }
        }
        protected void ClickFunc()
        {
            OnCreateNew();
            window.ClearContent();
            OnShow();
        }
        public virtual void OnExit()
        {

        }
        public virtual void OnShow()
        {
            window.ContentHeight = Height;
            window.ContentWidth = Width;
        }
        private int CollectionFindIndex(UIElementCollection c,UIElement e)
        {
            for(int i=0;i<c.Count;++i)
            {
                if (c[i] == e)
                    return i;
            }
            return -1;
        }
        public void CreateButtonShow()
        {
            int index = CollectionFindIndex(window.tw_content.Children, _create_button);
            if (index==-1)
                window.tw_content.Children.Add(_create_button);
        }
        public virtual void OnTransfer(TagWindow new_window)
        {
            window = new_window;
        }
        public virtual void OnLoad(string data)
        {
            IsCreated = true;
        }
        public virtual string OnSave()
        {
            return "";
        }
        public virtual void OnLostFocus()
        {

        }
        public virtual void OnPowerModeChange()
        {

        }
    }
}
