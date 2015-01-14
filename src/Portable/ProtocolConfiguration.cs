﻿using Hermes.Packets;

namespace Hermes
{
	public class ProtocolConfiguration
	{
		public ProtocolConfiguration ()
		{
			// The default receive buffer size of TcpClient according to
			// http://msdn.microsoft.com/en-us/library/system.net.sockets.tcpclient.receivebuffersize.aspx
			// is 8192 bytes
			this.BufferSize = 8192;
			this.AllowWildcardsInTopicFilters = true;
		}

		public int Port { get; set; }

		public int BufferSize { get; set; }

		public QualityOfService MaximumQualityOfService { get; set; }

		public ushort KeepAliveSecs { get; set; }

		public int WaitingTimeoutSecs { get; set; }

		public bool AllowWildcardsInTopicFilters { get; set; }
	}
}
