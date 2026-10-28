using System;
using System.Drawing;
using System.Windows.Forms;

namespace Q4_BrowserApp
{
    public class BrowserForm : Form
    {
        TextBox txtUrl;
        Button btnGo;
        Button btnBack;
        Button btnForward;
        Button btnRefresh;
        Button btnHome;
        Label lblStatus;
        WebBrowser browser;

        public BrowserForm()
        {
            Text = "Basic Web Browser";
            Width = 1100;
            Height = 700;
            StartPosition = FormStartPosition.CenterScreen;

            FlowLayoutPanel toolbar = new FlowLayoutPanel();
            toolbar.Dock = DockStyle.Top;
            toolbar.Height = 42;
            toolbar.WrapContents = false;
            toolbar.Padding = new Padding(5);

            btnBack = MakeButton("Back");
            btnBack.Enabled = false;
            btnBack.Click += btnBack_Click;

            btnForward = MakeButton("Forward");
            btnForward.Enabled = false;
            btnForward.Click += btnForward_Click;

            btnRefresh = MakeButton("Refresh");
            btnRefresh.Click += btnRefresh_Click;

            btnHome = MakeButton("Home");
            btnHome.Click += btnHome_Click;

            txtUrl = new TextBox();
            txtUrl.Width = 650;
            txtUrl.Margin = new Padding(5, 7, 5, 3);
            txtUrl.KeyDown += txtUrl_KeyDown;

            btnGo = MakeButton("Go");
            btnGo.Click += btnGo_Click;

            toolbar.Controls.Add(btnBack);
            toolbar.Controls.Add(btnForward);
            toolbar.Controls.Add(btnRefresh);
            toolbar.Controls.Add(btnHome);
            toolbar.Controls.Add(txtUrl);
            toolbar.Controls.Add(btnGo);

            lblStatus = new Label();
            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.Height = 25;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.ScriptErrorsSuppressed = true;
            browser.Navigating += browser_Navigating;
            browser.DocumentCompleted += browser_DocumentCompleted;

            Controls.Add(browser);
            Controls.Add(lblStatus);
            Controls.Add(toolbar);

            NavigateTo("https://www.google.com");
        }

        private Button MakeButton(string text)
        {
            Button button = new Button();
            button.Text = text;
            button.Width = 75;
            button.Height = 28;
            button.Margin = new Padding(3);
            return button;
        }

        private void NavigateTo(string address)
        {
            address = address.Trim();

            if (address == "")
                return;

            if (!address.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !address.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                address = "https://" + address;
            }

            Uri page;
            if (Uri.TryCreate(address, UriKind.Absolute, out page))
            {
                txtUrl.Text = page.ToString();
                browser.Navigate(page);
            }
            else
            {
                MessageBox.Show("Enter a valid web address.");
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            NavigateTo(txtUrl.Text);
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                NavigateTo(txtUrl.Text);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
                browser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward)
                browser.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            browser.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NavigateTo("https://www.google.com");
        }

        private void browser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            lblStatus.Text = "Loading...";
            UpdateNavigationButtons();
        }

        private void browser_DocumentCompleted(
            object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (browser.Url == null || e.Url != browser.Url)
                return;

            txtUrl.Text = browser.Url.ToString();
            lblStatus.Text = browser.DocumentTitle;
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            btnBack.Enabled = browser.CanGoBack;
            btnForward.Enabled = browser.CanGoForward;
        }
    }
}
