

#region References
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
#endregion // References

namespace Demo
{

  /// <summary>
  /// Just about the simplest sort of dialogue we can create.
  /// </summary>
  public class ConfirmPassword :Demo.DialogueBase
  {

    public ConfirmPassword(String dialogueCaption,
                           String dialogueKey):base()
    {
      DialogueKey  = dialogueKey;
      DialogueTitle = dialogueCaption;
    }

    protected override Panel AddDialogueControls(Panel controlContainer)
    {

      // Prompt the user.
      Label legend = new Label();
      legend.Text = "Your Favorite Star Name:";
      controlContainer.Controls.Add(legend);
      controlContainer.Controls.Add(new LiteralControl("<br/>"));

      // Set up somewhere for the user to enter his or her password.
      TextBox password = new TextBox();
      password.TextMode = TextBoxMode.Password;
      // Make very sure that we give the control an ID otherwise we won't 
      // be able to retrieve the value.
      password.ID = "myStar";
      password.AutoPostBack = false;
      controlContainer.Controls.Add(password);

      return controlContainer;
      
    }

  }

}
