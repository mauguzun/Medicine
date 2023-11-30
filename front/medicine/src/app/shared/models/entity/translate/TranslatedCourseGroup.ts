import { Language } from "../../../enums/Language";
import { User } from "../User";
import { CourseGroup } from "../CourseGroup";


export class TranslatedCourseGroup {
  courseGroup!: CourseGroup;
  courseGroupId!: number;
  title?: string;
  description?: string;
  language!: Language;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
