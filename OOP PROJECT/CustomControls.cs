using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP_PROJECT
{
    public class PlaceHolderTextBox : TextBox
    {
        bool isPlaceHolder = true;
        string _placeHolderText;
        public string PlaceHolderText
        {
            get { return _placeHolderText; }
            set
            {
                _placeHolderText = value;
                setPlaceholder();
            }
        }

        public new string Text
        {
            get => isPlaceHolder ? string.Empty : base.Text;
            set => base.Text = value;
        }

        //when the control loses focus, the placeholder is shown
        private void setPlaceholder()
        {
            
            if (string.IsNullOrEmpty(base.Text))
            {
                base.Text = PlaceHolderText;
                this.ForeColor = Color.Gray;
                

                this.Font = new Font("Rockwell", 12,FontStyle.Regular);
                
                
                isPlaceHolder = true;
            }
        }

        //when the control is focused, the placeholder is removed
        private void removePlaceHolder()
        {

            if (isPlaceHolder)
            {
                base.Text = "";
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                //this.Font = new Font(this.Font, FontStyle.Regular);
                this.Font = new Font("Rockwell", 12);
                //this.PasswordChar = '*';
                isPlaceHolder = false;
            }
        }
        public PlaceHolderTextBox()
        {
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            setPlaceholder();
        }

        private void removePlaceHolder(object sender, EventArgs e)
        {
            removePlaceHolder();
        }
    }
    public class PlaceHolderComboBox : ComboBox
    {
        bool isPlaceHolderCombo = true;
        string _placeHolderComboText;
        public string PlaceHolderComboText
        {
            get { return _placeHolderComboText; }
            set
            {
                _placeHolderComboText = value;
                setPlaceholderCombo();
            }
        }

        public new string Text
        {
            get => isPlaceHolderCombo ? string.Empty : base.Text;
            set => base.Text = value;
        }

        //when the control loses focus, the placeholder is shown
        private void setPlaceholderCombo()
        {
            if (string.IsNullOrEmpty(base.Text))
            {
                base.Text = PlaceHolderComboText;
                this.ForeColor = Color.Gray;
                this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolderCombo = true;
            }
        }

        //when the control is focused, the placeholder is removed
        private void removePlaceHolderCombo()
        {

            if (isPlaceHolderCombo)
            {
                base.Text = "";
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolderCombo = false;
            }
        }
        public PlaceHolderComboBox()
        {
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            setPlaceholderCombo();
        }

        private void removePlaceHolder(object sender, EventArgs e)
        {
            removePlaceHolderCombo();
        }
    }
    public class BorderlessButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.DrawRectangle(new Pen(this.BackColor, 5), this.ClientRectangle);
        }
    }
}


