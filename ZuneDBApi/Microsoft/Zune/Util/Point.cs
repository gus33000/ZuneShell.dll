namespace Microsoft.Zune.Util
{
	public class Point
	{
		private int m_x;

		private int m_y;

		public int Y
		{
			get
			{
				return m_y;
			}
			set
			{
				m_y = value;
			}
		}

		public int X
		{
			get
			{
				return m_x;
			}
			set
			{
				m_x = value;
			}
		}

		public Point(int x, int y)
		{
			m_x = x;
			m_y = y;
			base._002Ector();
		}

		public Point()
		{
			m_x = 0;
			m_y = 0;
			base._002Ector();
		}
	}
}