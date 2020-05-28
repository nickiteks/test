package subd.entity;

import javax.persistence.*;
import java.sql.Date;

@Entity
public class Orders {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;

    private String nomination;

    private Date date;

    @ManyToOne
    private Client client;

    @ManyToOne
    private Werehouse werehouse;

    public String toString() {
        return "Orders {\n" +
                "id =" + id + ",\n" +
                "nomination=" + nomination + ",\n" +
                "date=" + date + ",\n" +
                "}" + "\n";
    }
}
