package subd.entity;

import javax.persistence.*;
import java.util.List;

@Entity
public class Worker {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;

    private String post;

    private Integer experience;

    private String name;

    private String surname;

    private String patronymic;

    public Worker() {

    }
    public void Constructor(Integer id, String post, Integer experience, String name, String surname, String patronymic){
        this.post = post;
        this.experience = experience;
        this.name = name;
        this.surname = surname;
        this.patronymic = patronymic;
    }

    @OneToMany
    private List<Werehouse> werehouses;

    public String toString() {
        return "Worker {\n" +
                "id =" + id + ",\n" +
                "post=" + post + ",\n" +
                "experience=" + experience + ",\n" +
                "name=" + name + ",\n" +
                "surname=" + surname + ",\n" +
                "patronymic=" + patronymic + ",\n" +
                "}" + "\n";
    }
}
