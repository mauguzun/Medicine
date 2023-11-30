import { DosingFrequencyReminderDto } from "./DosingFrequencyReminderDto";
import { User } from "./User";
import { DosageLogStatus } from "../../enums/DosageLogStatus";


export class DosageLogDto {
  dosageRecommendation!: DosingFrequencyReminderDto;
  status!: DosageLogStatus;
  quantity!: number;
  dateTime!: Date;
  dosageRecommendationId!: number;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
