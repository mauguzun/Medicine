import { User } from "./User";
import { DosingFrequencyReminderDto } from "./DosingFrequencyReminderDto";

export class ReminderDto {
  dosingFrequencyReminders: DosingFrequencyReminderDto[] = [];
  timeInUtc?: string;
  title?: string;
  description?: string;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
