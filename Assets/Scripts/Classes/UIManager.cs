using UnityEngine;
using UnityEngine.UI;

public class UIManager : GameComponent
{
	public Image waterAlert;
	public Image soilAlert;
	public Image solarLightAlert;

	public UIManager(MediatorInterface gameMediator) : base(gameMediator) { }

	public void EnableWaterNeedIcon() {
		waterAlert.enabled = true;
	}

	public void EnableSoilNeedIcon() { 
		soilAlert.enabled = true;
	}

	public void EnableSolarLightNeedIcon() { 
		solarLightAlert.enabled = true;
	}

	public void DisableWaterNeedIcon() { 
		waterAlert.enabled=false;
	}

	public void DisableSoilNeedIcon() { 
	soilAlert.enabled=false;
	}

	public void DisableSolarLightNeedIcon() { 
		solarLightAlert.enabled=false;
	}

	public void DisableAllNeedIcon() { 
		DisableWaterNeedIcon(); 
		DisableSoilNeedIcon(); 
		DisableSolarLightNeedIcon(); 
	}
}
