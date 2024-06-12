namespace NotePad.Views;

public partial class NotePage : ContentPage
{
    string FileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

	public NotePage()
	{
		InitializeComponent();
	    
        if (File.Exists(FileName))
        {
            txtEditor.Text = File.ReadAllText(FileName);
        }
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(FileName, txtEditor.Text);
    }

    private void btnRemove_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(FileName))
        {
            File.Delete(FileName);
        }

        txtEditor.Text = string.Empty;
    }
}