#pragma once

#include "Modules/ModuleManager.h"

class FAB_ExtraEquipModule : public FDefaultGameModuleImpl {
public:
	virtual void StartupModule() override;

	virtual bool IsGameModule() const override { return true; }
};