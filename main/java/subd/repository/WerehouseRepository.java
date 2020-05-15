package subd.repository;

import subd.entity.Werehouse;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.sql.Timestamp;
import java.util.Date;
import java.util.List;

@Repository
public interface WerehouseRepository extends JpaRepository<Werehouse, Integer> {

    public List<Werehouse> getAllByDateBetween(Date fromDate, Date toDate);
}
