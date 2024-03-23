import { User } from "./User";
import { DosingFrequencyReminder } from "./DosingFrequencyReminder";
import { Drug } from "./Drug";
import { Course } from "./Course";
import { TranslatedDosingFrequency } from "./translate/TranslatedDosingFrequency";


export class DosingFrequency {
  course!: Course;
  courseId!: number;
  drug!: Drug;
  drugId!: number;
  total!: number;
  intervalInDays!: number;
  dosingFrequencyReminders: DosingFrequencyReminder[] = [];
  translations: TranslatedDosingFrequency[] = [];
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
