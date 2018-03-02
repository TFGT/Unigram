// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.getStickers.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesStickersBase"/>
	/// </summary>
	public partial class TLMessagesGetStickers : TLObject
	{
		public String Emoticon { get; set; }
		public String Hash { get; set; }

		public TLMessagesGetStickers() { }
		public TLMessagesGetStickers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetStickers; } }

		public override void Read(TLBinaryReader from)
		{
			Emoticon = from.ReadString();
			Hash = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Emoticon ?? string.Empty);
			to.WriteString(Hash ?? string.Empty);
		}
	}
}