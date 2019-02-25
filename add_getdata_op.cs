 /// <summary>
        /// handles data received from server
        /// </summary>
        /// <param name="sender">client instance</param>
        /// <param name="data">the data</param>
        private void _btclient_receiveddata(object sender, string data)
        {
            if(data.startswith("msg"))
            {
                var parts = data.split(':');

                message = parts[1];
            }
			else if(data.startswith("data"))
            {
                var parts = data.split(':');
                var partsData = parts[1].split(',');
				Measurement = partsData[0];
				Distance = partsData[1];
            }
            else if(data.startswith("op"))
            {
                var parts = data.split(':');
                var operations = parts[1].split(',');

                operations.clear();
                foreach(var op in operations)
                {
                    operations.add(op);
                }
            }
            // insert more handlers here
            else
            {
                message = $"unknown response {data}";
            }
// in XAML: Label Text="{Binding Measurement}"
// in VM: 
		public string Measurement
		{
			get { return _measurement; }
			set { this.RaiseAndSetIfChanged(ref _measurement, value); }
		}
// in XAML: Label Text="{Binding Distance}"
// in VM: 
		public string Distance
		{
			get { return _distance; }
			set { this.RaiseAndSetIfChanged(ref _distance, value); }
		}