import { Language } from "../../../enums/Language";
import { DosingFrequency } from "../DosingFrequency";
import { User } from "../User";



export class TranslatedDosingFrequency {
  dosingFrequencyId!: number;
  dosingFrequency!: DosingFrequency;
  title?: string; // Assuming title is optional since it's not marked with !
  description?: string; // Assuming description is optional
  language: Language = 0;
  createdBy?: User; // Assuming it can be nullable
  createdById!: number;
  id!: number;
  createdAt!: Date;
}
