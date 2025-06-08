using Engine;
namespace RPG_Project
{
    public partial class RPG_Project : Form
    {
        private Player _player;
        public RPG_Project()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1);

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void RPG_Project_Load(object sender, EventArgs e)
        {

        }
    }
}
