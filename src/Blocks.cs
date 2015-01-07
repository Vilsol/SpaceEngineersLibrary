using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Engineers_Library
{

    public interface IMyRadioAntenna : IMyFunctionalBlock {float Radius { get; }}
    public interface IMyRefinery : IMyProductionBlock {}
    public interface IMyVirtualMass : IMyFunctionalBlock {}
    public interface IMyAssembler : IMyProductionBlock {}
    public interface IMyBatteryBlock : IMyFunctionalBlock {bool HasCapacityRemaining { get; }}
    public interface IMyBeacon : IMyFunctionalBlock {float Radius { get; }}
    public interface IMyButtonPanel {bool AnyoneCanUse { get; }}
    public interface IMyCameraBlock : IMyFunctionalBlock {}
    public interface IMyCockpit : IMyShipController {}
    public interface IMyCollector : IMyFunctionalBlock {bool UseConveyorSystem { get; }}
    public interface IMyShipConnector : IMyFunctionalBlock {bool ThrowOut { get; } bool CollectAll { get; } bool IsLocked { get; }}
    public interface IMyControlPanel {}
    public interface IMyDoor : IMyFunctionalBlock {bool Open { get; }}
    public interface IMyShipDrill : IMyFunctionalBlock {bool UseConveyorSystem { get; }}
    public interface IMyLargeGatlingTurret : IMyLargeConveyorTurretBase {}
    public interface IMyGravityGenerator : IMyGravityGeneratorBase {float FieldWidth { get; } float FieldHeight { get; } float FieldDepth { get; }}
    public interface IMyShipGrinder : IMyShipToolBase {}
    public interface IMyGyro : IMyFunctionalBlock {float GyroPower { get; } bool GyroOverride { get; } float Yaw { get; } float Pitch { get; } float Roll { get; }}
    public interface IMyInteriorLight : IMyLightingBlock {}
    public interface IMyLargeInteriorTurret : IMyLargeTurretBase {}
    public interface IMyLandingGear : IMyFunctionalBlock {float BreakForce { get; }}
    public interface IMyCargoContainer {}
    public interface IMyReactor : IMyFunctionalBlock {bool UseConveyorSystem { get; }}
    public interface IMyThrust : IMyFunctionalBlock {float ThrustOverride { get; }}
    public interface IMyMedicalRoom : IMyFunctionalBlock {}
    public interface IMyShipMergeBlock : IMyFunctionalBlock {}
    public interface IMyLargeMissileTurret : IMyLargeConveyorTurretBase {}
    public interface IMyOreDetector : IMyFunctionalBlock {float Range { get; } bool BroadcastUsingAntennas { get; }}
    public interface IMyPistonBase : IMyFunctionalBlock {float Velocity { get; } float MinLimit { get; } float MaxLimit { get; }}
    public interface IMyProgrammableBlock : IMyFunctionalBlock {bool IsRunning { get; }}
    public interface IMyReflectorLight : IMyLightingBlock {}
    public interface IMyRemoteControl : IMyFunctionalBlock {bool ControlWheels { get; } bool ControlThrusters { get; } bool HandBrake { get; } bool DampenersOverride { get; }}
    public interface IMySmallMissileLauncher : IMyFunctionalBlock {bool UseConveyorSystem { get; }}
    public interface IMySmallMissileLauncherReload : IMyFunctionalBlock {bool UseConveyorSystem { get; }}
    public interface IMyMotorStator : IMyMotorBase {bool IsAttached { get; } float Torque { get; } float BrakingTorque { get; } float Velocity { get; } float LowerLimit { get; } float UpperLimit { get; } float Displacement { get; }}
    public interface IMySensorBlock : IMyFunctionalBlock {float LeftExtend { get; } float RightExtend { get; } float TopExtend { get; } float BottomExtend { get; } float FrontExtend { get; } float BackExtend { get; } bool DetectPlayers { get; } bool DetectFloatingObjects { get; } bool DetectSmallShips { get; } bool DetectLargeShips { get; } bool DetectStations { get; } bool DetectAsteroids { get; }}
    public interface IMySolarPanel {}
    public interface IMySoundBlock : IMyFunctionalBlock {float Volume { get; } float Range { get; } bool IsSoundSelected { get; } float LoopPeriod { get; }}
    public interface IMyGravityGeneratorSphere : IMyGravityGeneratorBase {float Radius { get; }}
    public interface IMyTimerBlock : IMyFunctionalBlock {bool IsCountingDown { get; } float TriggerDelay { get; }}
    public interface IMyWarhead {bool IsCountingDown { get; } float DetonationTime { get; }}
    public interface IMyShipWelder : IMyShipToolBase {}
    public interface IMyMotorSuspension : IMyMotorBase {bool Steering { get; } bool Propulsion { get; } float Dampening { get; } float Strength { get; } float Friction { get; } float Power { get; }}

}
