﻿using System;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200083E RID: 2110
	public abstract class PostProcessingComponentCommandBuffer<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x06003BBB RID: 15291
		public abstract CameraEvent GetCameraEvent();

		// Token: 0x06003BBC RID: 15292
		public abstract string GetName();

		// Token: 0x06003BBD RID: 15293
		public abstract void PopulateCommandBuffer(CommandBuffer cb);
	}
}
