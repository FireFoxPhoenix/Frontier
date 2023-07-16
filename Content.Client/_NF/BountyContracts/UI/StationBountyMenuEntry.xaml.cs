using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._NF.BountyContracts.UI;

[GenerateTypedNameReferences]
public sealed partial class StationBountyMenuEntry : Control
{
    public StationBountyMenuEntry(string bountyName, string bountyDesc,
        int price, string bountyAuthor)
    {
        RobustXamlLoader.Load(this);

        BountyName.Text = bountyName;
        BountyDescription.SetMessage(bountyDesc);

        if (price > 0)
        {
            BountyPrice.Text = Loc.GetString("cargo-console-menu-points-amount",
                ("amount", price.ToString()));
        }

        BountyAuthor.Text = Loc.GetString("station-bounties-ui-author",
            ("author", bountyAuthor));



    }
}
