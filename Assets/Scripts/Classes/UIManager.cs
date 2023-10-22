using UnityEngine;
public class UIManager : GameComponent
{
	public UIManager(MediatorInterface gameMediator) : base(gameMediator) { }

	public void EnableWaterNeedIcon() {
		Debug.LogWarning("Water Level Low!");
	}

	public void EnableSoilNeedIcon() { }

	public void EnableSolarLightNeedIcon() { }

	public void DisableWaterNeedIcon() { }

	public void DisableSoilNeedIcon() { }

	public void DisableSolarLightNeedIcon() { }

	public void DisableAllNeedIcon() { 
		DisableWaterNeedIcon(); 
		DisableSoilNeedIcon(); 
		DisableSolarLightNeedIcon(); 
	}
}
