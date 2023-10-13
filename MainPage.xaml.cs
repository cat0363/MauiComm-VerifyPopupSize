using CommunityToolkit.Maui.Views;
namespace MauiComm_VerifyPopupSize
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void btnTest1_Clicked(object sender, EventArgs e)
        {
            Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
            double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

            double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
            double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

            var popup1 = new PopupPage1();
            popup1.Size = new Size(popupWidth, popupHeight);
            popup1.VerticalOptions = verticalOptions;
            popup1.HorizontalOptions = horizontalOptions;
            popup1.Content.WidthRequest = contentWidth;
            popup1.Content.HeightRequest = contentHeight;
            this.ShowPopup(popup1);
        }

        void btnTest2_Clicked(object sender, EventArgs e)
        {
            Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
            double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

            double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
            double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

            var popup2 = new PopupPage2();
            popup2.Size = new Size(popupWidth, popupHeight);
            popup2.VerticalOptions = verticalOptions;
            popup2.HorizontalOptions = horizontalOptions;
            popup2.Content.WidthRequest = contentWidth;
            popup2.Content.HeightRequest = contentHeight;
            this.ShowPopup(popup2);
        }

        void btnTest3_Clicked(object sender, EventArgs e)
        {
            Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
            double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

            double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
            double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

            var popup3 = new PopupPage3();
            popup3.Size = new Size(popupWidth, popupHeight);
            popup3.VerticalOptions = verticalOptions;
            popup3.HorizontalOptions = horizontalOptions;
            popup3.Content.WidthRequest = contentWidth;
            popup3.Content.HeightRequest = contentHeight;
            this.ShowPopup(popup3);
        }

        void btnTest4_Clicked(object sender, EventArgs e)
        {
            Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
            double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

            double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
            double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

            var popup4 = new PopupPage4();
            popup4.Size = new Size(popupWidth, popupHeight);
            popup4.VerticalOptions = verticalOptions;
            popup4.HorizontalOptions = horizontalOptions;
            popup4.Content.WidthRequest = contentWidth;
            popup4.Content.HeightRequest = contentHeight;
            this.ShowPopup(popup4);
        }

        void btnTest5_Clicked(object sender, EventArgs e)
        {
            Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
            double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

            double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
            double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

            var popup5 = new PopupPage5();
            popup5.Size = new Size(popupWidth, popupHeight);
            popup5.VerticalOptions = verticalOptions;
            popup5.HorizontalOptions = horizontalOptions;
            popup5.Content.WidthRequest = contentWidth;
            popup5.Content.HeightRequest = contentHeight;
            this.ShowPopup(popup5);
        }
    }
}