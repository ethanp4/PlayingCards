namespace PlayingCards
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            listBoxPlayers.DataSource = Player.players;
            listBoxPlayers.SelectedIndexChanged += ListBoxPlayers_SelectedIndexChanged;
        }

        private void ListBoxPlayers_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var p = (Player)listBoxPlayers.SelectedItem;
            labelPlayer.Text = $"{p.name}\nTeam: {p.team}\nGames Played: {p.gamesPlayed}\nGoals: {p.goals}\nAssists: {p.assists}\nPoints: {p.points}";
            picturePlayer.ImageLocation = p.imageUrl;
        }
    }
}
