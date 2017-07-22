// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateBotWebhookJSONQuery : TLUpdateBase 
	{
		public Int64 QueryId { get; set; }
		public TLDataJSON Data { get; set; }
		public Int32 Timeout { get; set; }

		public TLUpdateBotWebhookJSONQuery() { }
		public TLUpdateBotWebhookJSONQuery(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateBotWebhookJSONQuery; } }

		public override void Read(TLBinaryReader from)
		{
			QueryId = from.ReadInt64();
			Data = TLFactory.Read<TLDataJSON>(from);
			Timeout = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt64(QueryId);
			to.WriteObject(Data);
			to.WriteInt32(Timeout);
		}
	}
}