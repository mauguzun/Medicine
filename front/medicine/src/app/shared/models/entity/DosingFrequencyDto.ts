import { CourseDto } from "./CourseDto";
import { DosingFrequencyReminderDto } from "./DosingFrequencyReminderDto";
import { DrugDto } from "./DrugDto";
import { TranslatedDto } from "./translate/TranslatedDto";

export class DosingFrequencyDto {
  translations: TranslatedDto[] = []
  course!: CourseDto;
  drug!: DrugDto;
  dosageRecommendations: DosingFrequencyReminderDto[] = [];
  courseId!: number;
  drugId!: number;
  total!: number;
  intervalInDays!: number;
  id!: number;
  createdAt?: Date;
}
