using System;
using System.Collections.Generic;

using Challenge.Core.Repository;

namespace Challenge.Core
{
	public class CustomerComponent
	{
		private CustomerRepository Repository{ get; set; }

		public CustomerComponent ()
		{
			Repository = new CustomerRepository(@"http://inttesttwilio.fcsamerica.com/imagecapture/api/");
		}

		public List<string> Submit (ImageCaptureEntity entity)
		{
			var answerUri = Repository.Submit (entity);
			return Repository.Get(answerUri);
		}
	}
}

