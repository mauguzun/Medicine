import { DosageLogStatus } from "../../enums/DosageLogStatus";
import { User } from "./User";
import { DosingFrequencyReminder } from "./DosingFrequencyReminder";


export class DosageLog {
  dosageRecommendationId!: number;
  dosageRecommendation!: DosingFrequencyReminder;
  status!: DosageLogStatus;
  quantity!: number;
  dateTime!: Date;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
