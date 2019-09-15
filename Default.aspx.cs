
#region References
using System;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
#endregion // References

namespace Demo
{
  public partial class _Default : System.Web.UI.Page
  {

    /// <summary>
    /// Page Load
    /// </summary>
    /// <param name="e"></param>
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
          
     // Label1.Text = "Click the button";
      loadPasswordDialogue();
    }

    /// <summary>
    /// Set up our password confirmation dialogue.
    /// </summary>
    private void loadPasswordDialogue()
    {
      // Each dialogue on the page requires a key. 
      // This should either be a constant or generated in a deterministic manner.
      ConfirmPassword settings = new ConfirmPassword("Favourite Star", 
                                                     "confirmPassword");
      settings.Height = Unit.Pixel(120);
      settings.Width = Unit.Pixel(200);

      // The dialogue (which is just a DIV remember) needs to be added
      // to the form's control collection.
      Page.Form.Controls.Add(settings);

      // Tie the dialogue to the control (such as a button) that will be 
      // used to display the dialogue.
      settings.BoundControl = this.starName;

      // Set up the code that'll act on the returned data.
      settings.DialogueClose +=new  CommandEventHandler(onSettingsClose);
    }

    /// <summary>
    /// Find out what the user entered in the dialogue.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    void onSettingsClose(object sender, CommandEventArgs e)
    {
      // Dialogue data is returned as nameValueCollection.
      NameValueCollection data = (NameValueCollection)e.CommandArgument;

      if (!DialogueBase.IsCancelled(data))
      {
        // The ID assigned to each control is used to name its returned value
        String password = data["myStar"];
               
                Label1.Text = string.Format("Your Favourite Start Name is : {0}", password);
      }
    }

        protected void accountSettings_Click(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
