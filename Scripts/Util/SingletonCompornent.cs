	/// <summary>
	/// シングルトンラッパー
	/// </summary>
	public static class SingletonCompornent<T> where T: class, new()
	{
		private static T instance = null;
		
		public static T Instance {
			get{
				if (instance == null) {
					instance = new T();
				}
				return instance;
			}
		}
		
		public static void Clear(){
			instance = null;
		}
		
	}
