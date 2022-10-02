using System.Text.RegularExpressions;

namespace Points
{
    public partial class Form1 : Form
    {
        private PointSet leftSet;
        private PointSet rightSet;
        private PointSet rSet;

        public Form1()
        {
            leftSet = new PointSet();
            rightSet = new PointSet();
            rSet = new PointSet();
            InitializeComponent();
        }

        private void inputKeyPressed(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            var regex1 = new Regex(@"[1-9\b-]");
            var regex2 = new Regex(@"[0-9\b]");
            if (!(tb.Text.Length == 0 && regex1.IsMatch(e.KeyChar.ToString())
                || tb.Text.Length != 0 && regex2.IsMatch(e.KeyChar.ToString())))
                e.Handled = true;
        }

        private void onPointsPlus(object sender, EventArgs e)
        {
            // if (text1L.Text == "" && text2L.Text == ""  && text1R.Text == ""  && text2R.Text == "")
            //     MessageBox.Show("Points coordinates must not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            try {
                var left = new Point(int.Parse(text1L.Text), int.Parse(text2L.Text));
                var right = new Point(int.Parse(text1R.Text), int.Parse(text2R.Text));
                rSet = left + right;

                resultSet.Nodes.Clear();
                rSet.set.ToList().ForEach(e => resultSet.Nodes.Add(e.ToString()));
            } catch (ArgumentNullException) {
                MessageBox.Show("Points cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (FormatException) {
                MessageBox.Show("Incorrect format exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (OverflowException) {
                MessageBox.Show("Number overflow exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onPointsEqual(object sender, EventArgs e)
        {
            try {
                var left = new Point(int.Parse(text1L.Text), int.Parse(text2L.Text));
                var right = new Point(int.Parse(text1R.Text), int.Parse(text2R.Text));

                label.Text = (left == right).ToString();
            } catch (ArgumentNullException) {
                MessageBox.Show("Points cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (FormatException) {
                MessageBox.Show("Incorrect format exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (OverflowException) {
                MessageBox.Show("Number overflow exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onPointsNoneq(object sender, EventArgs e)
        {
            try {
                var left = new Point(int.Parse(text1L.Text), int.Parse(text2L.Text));
                var right = new Point(int.Parse(text1R.Text), int.Parse(text2R.Text));

                label.Text = (left != right).ToString();
            } catch (ArgumentNullException) {
                MessageBox.Show("Points cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (FormatException) {
                MessageBox.Show("Incorrect format exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (OverflowException) {
                MessageBox.Show("Number overflow exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onPointAndSetMinusL(object sender, EventArgs e)
        {
            try {
                var left = new Point(int.Parse(text1L.Text), int.Parse(text2L.Text));

                leftSet = leftSet - left;

                set1.Nodes.Clear();
                leftSet.set.ToList().ForEach(e => set1.Nodes.Add(e.ToString()));
            } catch (ArgumentNullException) {
                MessageBox.Show("Points cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (FormatException) {
                MessageBox.Show("Incorrect format exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (OverflowException) {
                MessageBox.Show("Number overflow exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onPointAndSetPlusL(object sender, EventArgs e)
        {
            try {
                var left = new Point(int.Parse(text1L.Text), int.Parse(text2L.Text));

                leftSet = leftSet + left;

                set1.Nodes.Clear();
                leftSet.set.ToList().ForEach(e => set1.Nodes.Add(e.ToString()));
            } catch (ArgumentNullException) {
                MessageBox.Show("Points cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (FormatException) {
                MessageBox.Show("Incorrect format exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (OverflowException) {
                MessageBox.Show("Number overflow exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onPointAndSetMinusR(object sender, EventArgs e)
        {
            try {
                var right = new Point(int.Parse(text1R.Text), int.Parse(text2R.Text));

                rightSet = rightSet - right;

                set2.Nodes.Clear();
                rightSet.set.ToList().ForEach(e => set2.Nodes.Add(e.ToString()));
            } catch (ArgumentNullException) {
                MessageBox.Show("Points cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (FormatException) {
                MessageBox.Show("Incorrect format exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (OverflowException) {
                MessageBox.Show("Number overflow exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onPointAndSetPlusR(object sender, EventArgs e)
        {
            try {
                var right = new Point(int.Parse(text1R.Text), int.Parse(text2R.Text));

                rightSet = rightSet + right;

                set2.Nodes.Clear();
                rightSet.set.ToList().ForEach(e => set2.Nodes.Add(e.ToString()));
            } catch (ArgumentNullException) {
                MessageBox.Show("Points cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (FormatException) {
                MessageBox.Show("Incorrect format exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (OverflowException) {
                MessageBox.Show("Number overflow exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onPlusSet(object sender, EventArgs e)
        {
            resultSet.Nodes.Clear();

            rSet = leftSet + rightSet;
            rSet.set.ToList().ForEach(e => resultSet.Nodes.Add(e.ToString()));
        }

        private void onMinusSet(object sender, EventArgs e)
        {
            resultSet.Nodes.Clear();

            rSet = leftSet - rightSet;
            rSet.set.ToList().ForEach(e => resultSet.Nodes.Add(e.ToString()));
        }

        private void onSetEqual(object sender, EventArgs e)
        {
            label.Text = (leftSet == rightSet).ToString();
        }

        private void onSetNoneq(object sender, EventArgs e)
        {
            label.Text = (leftSet != rightSet).ToString();
        }

        private void onClearRight(object sender, EventArgs e)
        {
            rightSet = new PointSet();
            set2.Nodes.Clear();
        }

        private void onLeftClear(object sender, EventArgs e)
        {
            leftSet = new PointSet();
            set1.Nodes.Clear();
        }
    }
}