db.movies.findOne({$or:[{'tomatoes.viewer.rating': 3.2, genres: 'Drama'}, {genres: 'Musical'}], 
                   $nin:[1980, 1990, 2000, 2010, 2020]}, 
                   {title: 1, genres: 1, 'tomatoes.viewer.rating': 1})