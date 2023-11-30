import { User } from "./User";
import { DosingFrequencyReminder } from "./DosingFrequencyReminder";

export class Reminder {
  timeInUtc!: string;
  dosingFrequencyReminders: DosingFrequencyReminder[] = [];
  title?: string;
  description?: string;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
