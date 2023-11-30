import { User } from "./User";
import { TranslatedDosingFrequencyReminder } from "./translate/TranslatedDosingFrequencyReminder";
import { DosageLogDto } from "./DosageLogDto";
import { DosingFrequencyDto } from "./DosingFrequencyDto";

export class DosingFrequencyReminderDto {
  dosingFrequency: DosingFrequencyDto = new DosingFrequencyDto();
  dosageLogs: DosageLogDto[] = [];
  quantity!: number;
  usingDescription!: string;
  reminderId!: number;
  dosingFrequencyId!: number;
  translations: TranslatedDosingFrequencyReminder[] = [];
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
