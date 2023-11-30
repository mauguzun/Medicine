import { Language } from "../../enums/Language";
import { User } from "./User";
import { Course } from "./Course";
import { TranslatedCourseGroup } from "./translate/TranslatedCourseGroup";


export class CourseGroup {
  courses: Course[] = [];
  translations: TranslatedCourseGroup[] = [];
  title?: string;
  description?: string;
  language!: Language;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
