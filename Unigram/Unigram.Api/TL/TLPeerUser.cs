// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPeerUser : TLPeerBase 
	{
		public Int32 UserId { get; set; }

		public TLPeerUser() { }
		public TLPeerUser(TLBinaryReader from, TLType type = TLType.PeerUser)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.PeerUser; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.PeerUser)
		{
			UserId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9DB1BC6D);
			to.Write(UserId);
		}
	}
}