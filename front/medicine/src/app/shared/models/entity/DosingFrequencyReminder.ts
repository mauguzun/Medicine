import { Reminder } from "./Reminder";
import { DosingFrequency } from "./DosingFrequency";
import { DosageLog } from "./DosageLog";
import { User } from "./User";


export class DosingFrequencyReminder {
  title!: string;
  usingDescription!: string;
  quantity!: number;
  reminderId!: number;
  reminder!: Reminder;
  dosingFrequencyId!: number;
  dosingFrequency!: DosingFrequency;
  dosageLogs: DosageLog[] = [];
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
