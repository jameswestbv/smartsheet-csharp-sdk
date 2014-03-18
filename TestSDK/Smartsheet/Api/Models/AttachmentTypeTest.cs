namespace Smartsheet.Api.models
{
	using NUnit.Framework;
	using Smartsheet.Api.Models;
	using System;

	public class AttachmentTypeTest
	{

		[SetUp]
		public virtual void SetUp()
		{
		}

		[Test]
		public virtual void TestAttachmentType()
		{
			Assert.NotNull(AttachmentType.FILE);
			Assert.NotNull(AttachmentType.GOOGLE_DRIVE);
			Assert.NotNull(AttachmentType.LINK);
			Assert.NotNull(AttachmentType.BOX_COM);

			Assert.AreEqual(4,Enum.GetValues(typeof(AttachmentType)).Length);
		}

	}

}