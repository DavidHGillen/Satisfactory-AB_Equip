// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Equipment/FGConsumableEquipment.h"
#include "AB_EquipGlowstick.generated.h"

UENUM(BlueprintType)
enum class EGlowStickState : uint8
{
	EGS_Empty    = 0b00000,
	EGS_Drawn    = 0b00100,
	EGS_Cracked  = 0b01001,

	EGS_Drawing  = 0b01101,
	EGS_Cracking = 0b10001,
	EGS_Throwing = 0b10111,

	EGM_Lit      = 0b00010,
	EGM_Anim     = 0b00001
};

/**
 * 
 */
UCLASS()
class AB_EXTRAEQUIP_API AAB_EquipGlowstick : public AFGConsumableEquipment
{
	GENERATED_BODY()
	
	AAB_EquipGlowstick();

public:
	UPROPERTY(BlueprintReadWrite, SaveGame, /*Replicated,*/ Category = "GlowStick")
	EGlowStickState currentState = EGlowStickState::EGS_Empty;

	UPROPERTY(BlueprintReadWrite, /*Replicated,*/ Category = "GlowStick")
	float hueAngle = 0.0f;

	UPROPERTY(EditDefaultsOnly, BlueprintReadOnly, Category = "GlowStick")
	TSubclassOf<AActor> thrownStick;

protected:

};
